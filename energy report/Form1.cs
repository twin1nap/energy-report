using ClassLibraryCsv;
using ClassLibraryCsv.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace energy_report
{
    public partial class Form1 : Form
    {
        int month = 12;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxViewTypeStroom.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( sender as ComboBox == comboBoxViewTypeStroom)
            {
                comboBoxViewTypeGas.SelectedIndex = comboBoxViewTypeStroom.SelectedIndex;
            }
            else
            {
                comboBoxViewTypeStroom.SelectedIndex = comboBoxViewTypeGas.SelectedIndex;
            }
            int i = comboBoxViewTypeStroom.SelectedIndex;
            if (i == 0)
            {
                loadChartYear();
            }
            else if(i == 1)
            {
                loadChartMonth(month);
            }
        }

        private void loadChartYear()
        {
            data Data = new data();
            List<StroomData> stroomDatas = Data.GetStroom("meterstanden_stroom_2022" + ".csv");
            List<GasData> gasDatas = Data.GetGas("meterstanden_gas_2022" + ".csv");
            //modify data here to get the sum of each month

            var seriesStroom = chartStroom.Series["Stroom verbruik"];
            var seriesGas = chartGas.Series["Gas verbruik"];

                //stroomDatas = (from StroomData stroom in stroomDatas
                //               group stroom.OpnameDatum by stroom.OpnameDatum.Month into s
                //               select new { OpnameDatum = s.Key, StandNormaal = s.ToList()}
                ////select stroom).ToList().GroupBy( );

                //gasDatas = (from GasData gas in gasDatas
                //            where gas.OpnameDatum.Month == month
                //            select gas).ToList();

            seriesStroom.Points.Clear();
            seriesGas.Points.Clear();
            foreach (StroomData data in stroomDatas)
            {
                seriesStroom.Points.AddXY(data.OpnameDatum, (data.StandNormaal + data.StandDal));
            }
            foreach (GasData data in gasDatas)
            {
                seriesGas.Points.AddXY(data.OpnameDatum, data.Gas);
            }

        }

        private void loadChartMonth(int month)
        {
            data Data = new data();
            List<StroomData> stroomDatas = Data.GetStroom("meterstanden_stroom_2022" + ".csv");
            List<GasData> gasDatas = Data.GetGas("meterstanden_gas_2022" + ".csv");

            stroomDatas = (from StroomData stroom in stroomDatas
                          where stroom.OpnameDatum.Month == month
                          select stroom).ToList();

            gasDatas = (from GasData gas in gasDatas
                           where gas.OpnameDatum.Month == month
                           select gas).ToList();

            var seriesStroom = chartStroom.Series["Stroom verbruik"];
            var seriesGas = chartGas.Series["Gas verbruik"];
            seriesStroom.Points.Clear();
            seriesGas.Points.Clear();
            foreach (StroomData data in stroomDatas)
            {
                seriesStroom.Points.AddXY(data.OpnameDatum, (data.StandNormaal + data.StandDal));
            }
            foreach (GasData data in gasDatas)
            {
                seriesGas.Points.AddXY(data.OpnameDatum, data.Gas);
            }
        }
    }
}
