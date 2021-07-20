using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork0716.Forms
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        #region 建立Dictionary
        //打開此Form後必須先建立各Diction才能使用否則無效
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            CreateBigCarDic();
            CreateBussiCarrDic();
            CreateMotorDic();
            CreateTruckDic();
            CreateSelfCarDic();
        }
        #endregion

        #region RadioBtn設定
        //RadioButtonM(依期間)Checked與否來決定接下來的功能選項出現與否

        private void radioBtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnM.Checked == true)
            {
                lblFrom.Visible = true;
                lblTo.Visible = true;
                DTPFrom.Visible = true;
                DTPTo.Visible = true;
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                DTPFrom.Visible = false;
                DTPTo.Visible = false;
            }
        }
        #endregion

        #region 各車種選項資料(CC數)
        string[] Motor = {"150以下","151 - 250", "251 - 500","501 - 600",
        "601 - 1200","1201 - 1800","1800以上"};

        string[] Truck = {"500以下","501 - 600", "601 - 1200","1201 - 1800",
        "1801 - 2400","2401 - 3000","3001 - 3600","3601 - 4200","4201 - 4800",
        "4801 - 5400","5401 - 6000","6001 - 6600","6601 - 7200","7201 - 7800",
        "7801 - 8400","8401 - 9000","9001 - 9600","9600 - 10200","10201以上"
        };

        string[] BigCar = {"600以下", "601 - 1200","1201 - 1800",
        "1801 - 2400","2401 - 3000","3001 - 3600","3601 - 4200","4201 - 4800",
        "4801 - 5400","5401 - 6000","6001 - 6600","6601 - 7200","7201 - 7800",
        "7801 - 8400","8401 - 9000","9001 - 9600","9600 - 10200","10201以上"
        };

        string[] SelfCar = {"500以下","501 - 600", "601 - 1200","1201 - 1800",
        "1801 - 2400","2401 - 3000","3001 -  4200","4201 - 5400","5401 - 6600","6601 - 7800",
        "7801以上"
        };

        string[] BussiCar = {"500以下","501 - 600", "601 - 1200","1201 - 1800",
        "1801 - 2400","2401 - 3000","3001 -  4200","4201 - 5400","5401 - 6600","6601 - 7800",
        "7801以上"
        };
        #endregion

        #region 各車種年繳稅額資料
        int[] MotorPrice = {0,800,1620,2160,4320,7120,11230
        };
        int[] TruckPrice = {900,1080,1800,2700,3600,4500,5400,6300,7200,8100,9000,9900,
                10800,11700,12600,13500,14400,15300,16200
        };
        int[] BigCarPrice = {1080,1800,2700,3600,4500,5400,6300,7200,8100,9000,9900,10800,
            11700,12600,13500,14400,15300,16200
        };
        int[] SelfCarPrice = {1620,2160,4320,7120,11230,15210,28220,46170,69690,117000,151200
        };
        int[] BussiCarPrice ={900,1260,2160,3060,6480,9900,16380,24300,33660,44460,56700

        };
        #endregion

        #region 各車種索引鍵,對應值配對設定
        //利用Dictionary給各"車種之CC"數設鍵,並賦予年稅額陣列裡相對應的"值",若陣列長度不同則可能造成溢出bug.

        Dictionary<string, int> MotorDic = new Dictionary<string, int>(); //Dictionary<車種CC數陣列(string), 年稅額陣列(int)> MortorDic(Dic名稱) = new Dictionary<string, int>()
        private void CreateMotorDic()//利用for迴圈給每個鍵一個值
        {
            for (int i = 0; i < Motor.Length; i++)//Motor.Length = Motor陣列之長度
            {
                MotorDic.Add(Motor[i], MotorPrice[i]);
            }
        }

        Dictionary<string, int> TruckDic = new Dictionary<string, int>();
        private void CreateTruckDic()
        {
            for (int i = 0; i < Truck.Length; i++)
            {
                TruckDic.Add(Truck[i], TruckPrice[i]);
            }
        }

        Dictionary<string, int> BigCarDic = new Dictionary<string, int>();
        private void CreateBigCarDic()
        {
            for (int i = 0; i < BigCar.Length; i++)
            {
                BigCarDic.Add(BigCar[i], BigCarPrice[i]);
            }
        }

        Dictionary<string, int> SelfCarDic = new Dictionary<string, int>();
        private void CreateSelfCarDic()
        {
            for (int i = 0; i < SelfCar.Length; i++)
            {
                SelfCarDic.Add(SelfCar[i], SelfCarPrice[i]);
            }
        }

        Dictionary<string, int> BussiCarDic = new Dictionary<string, int>();
        private void CreateBussiCarrDic()
        {
            for (int i = 0; i < BussiCar.Length; i++)
            {
                BussiCarDic.Add(BussiCar[i], BussiCarPrice[i]);
            }
        }
        #endregion

        #region 各車種之相應CC數顯示設定
        //依造使用者在CBboxUse(用途)的選擇來決定CBboxCC(CC數)呈現內容
        private void CBboxUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBboxUse.SelectedItem)//用Switch去逐個檢視並決定使用哪一個Case
            {
                case "機車":
                    CBboxCC.Items.Clear();//若CBboxUse選則機車,則清空CBboxCC內容
                    CBboxCC.Items.AddRange(Motor);//並且呈現出Motor陣列裡的CC數內容
                    break;

                case "貨車":
                    CBboxCC.Items.Clear();
                    CBboxCC.Items.AddRange(Truck);
                    break;

                case "大客車":
                    CBboxCC.Items.Clear();
                    CBboxCC.Items.AddRange(BigCar);
                    break;

                case "自用小客車":
                    CBboxCC.Items.Clear();
                    CBboxCC.Items.AddRange(SelfCar);
                    break;

                case "營業用小客車":
                    CBboxCC.Items.Clear();
                    CBboxCC.Items.AddRange(BussiCar);
                    break;
            }
            CBboxCC.SelectedIndex = 0;
        }
        #endregion

        #region 呼叫年繳額
        //利用前面建立的Diction呼叫出相應的"值"(年繳額)
        private int PriceYear()
        {
            int price = 0;

            switch (CBboxUse.SelectedItem)                                  //若使用者CC數選擇為某case,則叫出相應年繳額
            {
                case "機車":
                    price = MotorDic[CBboxCC.SelectedItem.ToString()];
                    break;

                case "貨車":
                    price = TruckDic[CBboxCC.SelectedItem.ToString()];
                    break;

                case "大客車":
                    price = BigCarDic[CBboxCC.SelectedItem.ToString()];
                    break;

                case "自用小客車":
                    price = SelfCarDic[CBboxCC.SelectedItem.ToString()];
                    break;

                case "營業用小客車":
                    price = BussiCarDic[CBboxCC.SelectedItem.ToString()];
                    break;
            }
            return price;
        }
        #endregion

        #region  計算每年天數(是否為閏年)
        private int[] DaysOfEveryYears(int[] year)
        {
            int[] daysOfEveryYears = new int[year.Length];

            for (int i = 0; i < year.Length; i++)
            {
                if (DateTime.IsLeapYear(year[i]))
                {
                    daysOfEveryYears[i] = 366;
                }
                else
                {
                    daysOfEveryYears[i] = 365;
                }
            }
            return daysOfEveryYears;
        }
        #endregion

        #region 尋找每年區間
        //利用使用者在DTPFFrom及DTPTo選取的兩個DateTime值算出區間
        private DateTime[,] Period(DateTime starTime, DateTime endTime)                                                                            
        {                                                                            
            DateTime[,] period = new DateTime[endTime.Year - starTime.Year + 1, 2];             //利用二維陣列找出每年區間(EX.2019/7/1-2021/8/1 [0,0]為2019/7/1,[0,1]為2019/12/31,
                                                                                                //                                              [1,0]為2019/1/1,[1,1]為2019/12/31,
            for (int i = 0; i < endTime.Year - starTime.Year + 1; i++)                          //                                              [2,0]為2021/1/1,[2,2]為2021/8/1,
            {                                                                             
                if (i == 0)
                {
                    period[i, 0] = starTime.Date;                                               //將DateTime鎖定在Date去掉不必要餘數以避免誤差
                }
                else
                {
                    period[i, 0] = new DateTime(starTime.Year + i, 1, 1);
                }

                if (i == endTime.Year - starTime.Year)
                {
                    period[i, 1] = endTime;
                }
                else
                {
                    period[i, 1] = new DateTime(starTime.Year + i, 12, 31);
                }
            }
            return period;
        }
        #endregion

        #region 計算每區間天數
        private int[] DaysOfEveryPeriod (DateTime[,] period)                                     //利用前面二微陣列取出DateTime算出 1.starTime至當年年尾, 2.中間年天數, 3.最後一年1/1至endTime天數
        {
            int[] daysOfEveryPeriod = new int [period.GetLength(0)];                             //用"GetLength"取二維陣列第一維之長度

            for (int i = 0; i < period.GetLength(0); i++)
            {
               daysOfEveryPeriod[i] = (period[i, 1] - period[i,0]).Days + 1;
            }
            return daysOfEveryPeriod;
        }
        #endregion

        #region 每年應繳稅額計算
        private int[] Answer (int price, int[] days, int[] DOY) //取年繳額,天數陣列以及每年總天數陣列三個值計算每年應繳稅額

        {
            int[] answer = new int[days.Length];//陣列長度取決於陣列天數來多少值
            
            for(int i = 0; i < days.Length; i++)
            {
                answer[i] = price *  days[i] / DOY[i];
            }
            return answer; //回傳陣列
        }
        #endregion

        #region 計算按鈕功能設定
        private void btnCQL_Click(object sender, EventArgs e)
        {
            DateTime startDay;
            DateTime endDay;
            int totalYear = DTPTo.Value.Year - DTPFrom.Value.Year + 1;//共幾年
            int[] EveryYear = new int[totalYear];//每一年分
            int[] DsOPrs = new int[totalYear];   //每一區間之天數
            int[] DsOYs = new int[totalYear];    //每一年天數
            int[] EYAnswer = new int[totalYear]; //每年應繳稅額
            int price = PriceYear();

            //計算每一年之年分
            for (var i = 0; i < totalYear; i++) 
            {
                EveryYear[i] = DTPFrom.Value.Year + i;
            } 
         

            //判斷使用者所選計算日期
            if (radioBtnM.Checked == true)//若使用者按下"依期間"按鈕,則starDay及endDay為使用者所選日期
            {
                 startDay = DTPFrom.Value;
                 endDay = DTPTo.Value;
            } 
            else //否則依照當年年頭至年尾計算
            {
                 startDay = new DateTime(DateTime.Now.Year, 1, 1);
                 endDay = new DateTime(DateTime.Now.Year, 12, 31);
            }
            

             DateTime[,] period = Period(startDay, endDay);
             DsOPrs = DaysOfEveryPeriod(period);
             DsOYs = DaysOfEveryYears(EveryYear);
             EYAnswer = Answer(price, DsOPrs, DsOYs);
          
             //計算總應繳稅額
             int totalPrice = 0;
             for(int i =0; i<EYAnswer.Length; i++)
            {
               totalPrice = totalPrice + EYAnswer[i];
            }
             

            //利用for迴圈顯示TextBox內容
            for (int i = 0; i<totalYear; i++)
            {
                textBox1.Text += $"使用期間:{period[i,0]} - {period[i,1]} {Environment.NewLine}計算天數: {DsOPrs[i]}{Environment.NewLine}" +
                    $"汽缸CC數: {CBboxCC.SelectedItem}{Environment.NewLine}用途: {CBboxUse.SelectedItem}{Environment.NewLine}計算公式: {price} * {DsOPrs[i]} / {DsOYs[i]} = {EYAnswer[i]}元" +
                 $"{ Environment.NewLine} 年應納稅額: {EYAnswer[i]}{Environment.NewLine}{Environment.NewLine}";
            }
            textBox1.Text += $"總應納稅額: {totalPrice}"; //TextBox內容最後再加上總應繳稅額
          
        }
        #endregion

        #region 清除按鈕功能設定
        private void btnDle_Click(object sender, EventArgs e)
        {
            
            CBboxUse.Text = "              ----------請選擇----------";
            CBboxCC.Text = "              ----------請選擇----------";
            radioBtnM.Checked = false;
        }
        #endregion
    }
}

