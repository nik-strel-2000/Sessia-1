using CarsStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsStation
{
    public partial class EditTable : Form
    {
        public EditTable()
        {
            InitializeComponent();
        }
            
        public List<Gasoline> Req_data(string item)
        {
            List<Gasoline> gasolines = JsonSerializer.Deserialize<List<Gasoline>>(item);
            return gasolines;
            int i = 1;
            string file = File.ReadAllText("C:\\Users\\Nik\\Downloads\\Car_Filling_Station.json");
            List<CarFillingStation> person = JsonSerializer.Deserialize<List<CarFillingStation>>(file);

            foreach (CarFillingStation json in person)
            {

                //JsonPost(json, i);
                i++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void EditTable_Load(object sender, EventArgs e)
        {

        }
    }
}
