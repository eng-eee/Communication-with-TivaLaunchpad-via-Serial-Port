#include <stdint.h>
#include <stdbool.h>
#include "inc/tm4c123gh6pm.h"
#include "lcd.h"
#include "inc/hw_memmap.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "inc/hw_gpio.h"
#include "driverlib/pin_map.h";
#include "driverlib/uart.h"
#include "driverlib/interrupt.h"
#include "driverlib/adc.h"
#include "driverlib/timer.h"

char InitValues[8];
int second=0,min=0,hour=0;
int val,TempValueC,onlar=0,birler=0;

void SendUartString(uint32_t nBase, char* string){
    while(*string != '\0')
        if(UARTSpaceAvail(nBase))
            UARTCharPut(nBase, *string++);
}
void Initclock(){
    hour=(InitValues[2]%48)*10+InitValues[3]%48;
    min=(InitValues[4]%48)*10+InitValues[5]%48;
    second=(InitValues[6]%48)*10+InitValues[7]%48;
}
void func(){
    LcdClear();
    LcdSetCursor(0, 0);
    LcdPrint("TIME ");
    int i=2;
    while(i<8){
        LcdWrite(InitValues[i++]);
        if(i%2==0)
            LcdWrite(':');
    }
    Initclock();
}
void ParseClock(int parseval,int*low,int*high){
    *low=parseval%10;
    *high=parseval/10;
}
void LcdClockWrite(){
    int secondlow,secondhigh,minlow,minhigh,hourlow,hourhigh;
    ParseClock(second,&secondlow,&secondhigh);
    ParseClock(min,&minlow,&minhigh);
    ParseClock(hour,&hourlow,&hourhigh);
    LcdHome();
    LcdSetCursor(0,0);
    LcdPrint("TM");
    LcdWrite(48+hourhigh);
    LcdWrite(48+hourlow);
    LcdWrite(':');
    LcdWrite(48+minhigh);
    LcdWrite(48+minlow);
    LcdWrite(':');
    LcdWrite(secondhigh+48);
    LcdWrite(secondlow+48);
    LcdSetCursor(0, 10);
    LcdPrint("Adc:");
    LcdWrite(onlar+48);
    LcdWrite(birler+48);
    SendUartString(UART0_BASE,"#ADC=");
    UARTCharPut(UART0_BASE, onlar+48);
    UARTCharPut(UART0_BASE, birler+48);
}

void AdcInt(){
    uint32_t adcintstatus = ADCIntStatus(ADC0_BASE, 3, true);
    ADCIntClear(ADC0_BASE, 3);
    ADCSequenceDataGet(ADC0_BASE, 3, &val);
    TempValueC = (1475 - ((2475 * val)) / 4096)/10;
    onlar=TempValueC/10;
    birler=TempValueC%10;
}
void TimerInt(){
    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
    second++;
    if(second==60){
        second=0;
        min++;
        if(min==60){
            min=0;
            hour++;
            if(hour==24)
                hour=0;
        }
    }
    LcdClockWrite();
}

void SetInit(){
    SysCtlClockSet(SYSCTL_SYSDIV_4|SYSCTL_USE_PLL|SYSCTL_OSC_MAIN|SYSCTL_XTAL_16MHZ);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_TIMER0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);
    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA);

    GPIOPinTypeGPIOInput(GPIO_PORTF_BASE, GPIO_PIN_4);
    GPIOPadConfigSet(GPIO_PORTF_BASE, GPIO_PIN_4, GPIO_STRENGTH_8MA, GPIO_PIN_TYPE_STD_WPU);

    ADCSequenceDisable(ADC0_BASE, 3);
    ADCSequenceConfigure(ADC0_BASE, 3, ADC_TRIGGER_PROCESSOR, 0);
    ADCSequenceStepConfigure(ADC0_BASE, 3, 0, ADC_CTL_TS|ADC_CTL_IE|ADC_CTL_END);
    ADCSequenceEnable(ADC0_BASE, 3);
    ADCIntRegister(ADC0_BASE, 3, AdcInt);
    ADCIntClear(ADC0_BASE, 3);
    ADCIntEnable(ADC0_BASE, 3);
    IntEnable(INT_ADC0SS3);

    TimerDisable(TIMER0_BASE, TIMER_A);
    TimerConfigure(TIMER0_BASE, TIMER_CFG_A_PERIODIC);
    TimerLoadSet(TIMER0_BASE, TIMER_A, SysCtlClockGet()-1);
    IntEnable(INT_TIMER0A);
    TimerIntRegister(TIMER0_BASE, TIMER_A, TimerInt);
    TimerIntClear(TIMER0_BASE, TIMER_TIMA_TIMEOUT);
    TimerIntEnable(TIMER0_BASE, TIMER_TIMA_TIMEOUT);

    UARTDisable(UART0_BASE);
    GPIOPinConfigure(GPIO_PA0_U0RX);
    GPIOPinConfigure(GPIO_PA1_U0TX);
    GPIOPinTypeUART(GPIO_PORTA_BASE,GPIO_PIN_0|GPIO_PIN_1);
    UARTConfigSetExpClk(UART0_BASE, SysCtlClockGet() , 9600, UART_CONFIG_PAR_NONE|UART_CONFIG_STOP_ONE|UART_CONFIG_WLEN_8);
    UARTFIFODisable(UART0_BASE);

    IntMasterEnable();

    LcdInit();
    LcdDisplayOn();
}

void main(void)
{
    char rc_data[14];
    int cnt=0;
    SetInit();
    UARTEnable(UART0_BASE);
    TimerEnable(TIMER0_BASE, TIMER_A);
    while(1){
        ADCProcessorTrigger(ADC0_BASE, 3);
        while(UARTCharsAvail(UART0_BASE)){
            rc_data[cnt] = UARTCharGet(UART0_BASE);
            if(rc_data[0]=='#'){ // # gelirse lcd 2. satir temizler
                LcdClear();
            }
            else if(rc_data[0]=='*'){ // * gelirse saatin ilk degerleri girilir (baslangýcta 00:00:00 olarak ayarlý)
                UARTCharPut(UART0_BASE, rc_data[cnt]);
                InitValues[cnt]=rc_data[cnt];
                if(cnt==7)
                    func(); // saat degerlerini ekrana yazar ve initclok fonksiyonuna cagri yapar min second hour deger atamalari yapar
            }
            else
                if(rc_data[cnt+1]=='*'){ // seri port üzerinden gelen metni lcd 2. satirina yaz (sondaki yildiz karakterine kadar)
                    LcdSetCursor(1, 0);
                    LcdPrint(rc_data);
                }
            cnt++;
        }
        cnt=0;
        if(GPIOPinRead(GPIO_PORTF_BASE, GPIO_PIN_4)==0){ //pf 4 butonuna basilirsa seri porta merhaba yazar
            while(!(GPIOPinRead(GPIO_PORTF_BASE, GPIO_PIN_4)));
            UARTCharPut(UART0_BASE, '*');
            UARTCharPut(UART0_BASE, 'M');
            UARTCharPut(UART0_BASE, 'E');
            UARTCharPut(UART0_BASE, 'R');
            UARTCharPut(UART0_BASE, 'H');
            UARTCharPut(UART0_BASE, 'A');
            UARTCharPut(UART0_BASE, 'B');
            UARTCharPut(UART0_BASE, 'A');
            UARTCharPut(UART0_BASE, '\n');
        }
    }
}
