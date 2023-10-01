using fastfoodapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fastfoodapp
{
    public partial class MainForm : Form
    {
        List<Zakas> zakaslar = new List<Zakas>();
        int Sum_total = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_stlp_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_s_tandir_l.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_s_tandir_l.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_s_tandir_l_narxi.Text);

            Sum_total += int.Parse(lb_s_tandir_l_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            lb_s_tandir_l_h.Text = zakaslar[index].Count.ToString();
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_tandir_lavash_p_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tandir_lavash.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_tandir_lavash.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;

            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_tandir_lavash_narxi.Text);

            Sum_total += int.Parse(lb_tandir_lavash_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            lb_tandir_lavash_h.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }


        }

        private void btn_stlm_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_s_tandir_l.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_s_tandir_l_narxi.Text);
                    lb_s_tandir_l_h.Text = zakaslar[index].Count.ToString();



                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_s_tandir_l_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_s_tandir_l_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();

            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }

        }

        private void btn_tandir_lavash_m_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tandir_lavash.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_tandir_lavash_narxi.Text);

                    lb_tandir_lavash_h.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_tandir_lavash_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_tandir_lavash_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pn_drink.Visible = false;
            pn_desert.Visible = false;
        }

        private void btn_tandir_lavash_mini_p_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tandir_lavash_mini.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_tandir_lavash_mini.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;

            }

            Sum_total += int.Parse(lb_tandir_lavash_mini_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_tandir_lavash_mini_narxi.Text);
            lb_tandir_lavash_mini_h.Text = zakaslar[index].Count.ToString();
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_sirli_tovuqli_lavash_p_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_sirli_tovuqli_lavash.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_sirli_tovuqli_lavash.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;

            }
            Sum_total += int.Parse(lb_sirli_tovuqli_lavash_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_sirli_tovuqli_lavash_narxi.Text);

            lb_sirli_tovuqli_lavash_h.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_tovuqli_lavash_p_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tovuqli_lavash.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_tovuqli_lavash.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;

            }
            Sum_total += int.Parse(lb_tovuqli_lavash_narx.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_tovuqli_lavash_narx.Text);

            lb_tovuqli_lavash_h.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_tovuqli_lavsh_mini_p_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tovuqli_lavsh_mini.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_tovuqli_lavsh_mini.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;

            }
            Sum_total += int.Parse(lb_tovuqli_lavsh_mini_narx.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_tovuqli_lavsh_mini_narx.Text);

            lb_tovuqli_lavsh_mini_h.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_tandir_lavash_mini_m_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tandir_lavash_mini.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_tandir_lavash_mini_narxi.Text);

                    lb_tandir_lavash_mini_h.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_tandir_lavash_mini_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_tandir_lavash_mini_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_sirli_tovuqli_lavash_m_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_sirli_tovuqli_lavash.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_sirli_tovuqli_lavash_narxi.Text);

                    lb_sirli_tovuqli_lavash_h.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_sirli_tovuqli_lavash_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_sirli_tovuqli_lavash_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_tovuqli_lavash_m_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tovuqli_lavash.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_tovuqli_lavash_narx.Text);

                    lb_tovuqli_lavash_h.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_tovuqli_lavash_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_tovuqli_lavash_narx.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_tovuqli_lavsh_mini_m_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_tovuqli_lavsh_mini.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_tovuqli_lavsh_mini_narx.Text);

                    lb_tovuqli_lavsh_mini_h.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_tovuqli_lavsh_mini_h.Text = "0";

                }
                Sum_total -= int.Parse(lb_tovuqli_lavsh_mini_narx.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void label256_Click(object sender, EventArgs e)
        {

        }

        private void btn_blessing_c_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_blessing_c_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_blessing_c_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            Sum_total += int.Parse(lb_blessing_c_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_blessing_c_narxi.Text);

            lb_blessing_c_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void lb_double_c_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_double_c_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_double_c_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            Sum_total += int.Parse(lb_double_c_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_double_c_narxi.Text);

            lb_double_c_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_lavash_c_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_lavash_c_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_lavash_c_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            Sum_total += int.Parse(lb_lavash_c_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_lavash_c_narxi.Text);

            lb_lavash_c_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_gamburger_c_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_gamburger_c_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_gamburger_c_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            Sum_total += int.Parse(lb_gamburger_c_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_gamburger_c_narxi.Text);

            lb_gamburger_c_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_shourma_c_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_shourma_c_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_shourma_c_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            Sum_total += int.Parse(lb_shourma_c_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_shourma_c_narxi.Text);

            lb_shourma_c_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_blessing_c_minus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_blessing_c_name.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_blessing_c_narxi.Text);

                    lb_blessing_c_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_blessing_c_hisob.Text = "0";

                }
                Sum_total -= int.Parse(lb_blessing_c_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void lb_double_c_minus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_double_c_name.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_double_c_narxi.Text);

                    lb_double_c_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_double_c_hisob.Text = "0";

                }
                Sum_total -= int.Parse(lb_double_c_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_lavash_c_minus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_lavash_c_name.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_lavash_c_narxi.Text);

                    lb_lavash_c_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_lavash_c_hisob.Text = "0";

                }
                Sum_total -= int.Parse(lb_lavash_c_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_gamburger_c_minus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_gamburger_c_name.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_gamburger_c_narxi.Text);

                    lb_gamburger_c_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_gamburger_c_hisob.Text = "0";

                }
                Sum_total -= int.Parse(lb_gamburger_c_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_shourma_c_minus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_shourma_c_name.Text);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(lb_shourma_c_narxi.Text);

                    lb_shourma_c_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_shourma_c_hisob.Text = "0";

                }
                Sum_total -= int.Parse(lb_shourma_c_narxi.Text);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_hotdog_pilus_Click(object sender, EventArgs e)
        {
            var isHave = zakaslar.FirstOrDefault(x => x.Name == lb_hotdog_name.Text);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = lb_hotdog_name.Text;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(lb_hotdog_narxi.Text);

            Sum_total += int.Parse(lb_hotdog_narxi.Text);
            lb_Sum.Text = Sum_total.ToString();

            lb_hotdog_hisob.Text = zakaslar[index].Count.ToString();
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_cheese_hotdog_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_cheese_hotdog_name.Text;
            string hisob = lb_cheese_hotdog_hisob.Text;
            string narxi = lb_cheese_hotdog_narxi.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_cheese_hotdog_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_double_hotdog_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_double_hotdog_name.Text;
            string hisob = lb_double_hotdog_hisob.Text;
            string narxi = lb_double_hotdog_narxi.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_double_hotdog_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_haggi_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_haggi_name.Text;
            string hisob = lb_haggi_hisob.Text;
            string narxi = lb_haggi_narxi.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_haggi_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_hotdog_minus_Click(object sender, EventArgs e)
        {
            string name = lb_hotdog_name.Text;
            string hisob = lb_hotdog_hisob.Text;
            string narxi = lb_hotdog_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_hotdog_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_hotdog_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_double_hotdog_minus_Click(object sender, EventArgs e)
        {
            string name = lb_double_hotdog_name.Text;
            string hisob = lb_double_hotdog_hisob.Text;
            string narxi = lb_double_hotdog_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_double_hotdog_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_double_hotdog_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_cheese_hotdog_minus_Click(object sender, EventArgs e)
        {
            string name = lb_cheese_hotdog_name.Text;
            string hisob = lb_cheese_hotdog_hisob.Text;
            string narxi = lb_cheese_hotdog_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_cheese_hotdog_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_cheese_hotdog_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_haggi_minus_Click(object sender, EventArgs e)
        {
            string name = lb_haggi_name.Text;
            string hisob = lb_haggi_hisob.Text;
            string narxi = lb_haggi_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_haggi_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_haggi_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_gam_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_gam_name.Text;
            string narxi = lb_gam_narxi.Text;
            string hisob = lb_gam_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_gam_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_big_gam_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_big_gam_name.Text;
            string narxi = lb_big_gam_narxi.Text;
            string hisob = lb_big_gam_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_big_gam_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_chiz_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_chiz_name.Text;
            string narxi = lb_chiz_narxi.Text;
            string hisob = lb_chiz_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_chiz_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_big_chiz_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_big_chiz_name.Text;
            string narxi = lb_big_chiz_narxi.Text;
            string hisob = lb_big_chiz_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_big_chiz_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_donar_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_donar_name.Text;
            string narxi = lb_donar_narxi.Text;
            string hisob = lb_donar_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_donar_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_shourma_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_shourma_name.Text;
            string narxi = lb_shourma_narxi.Text;
            string hisob = lb_shourma_hisob.Text;


            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_shourma_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_gam_ninus_Click(object sender, EventArgs e)
        {
            string name = lb_gam_name.Text;
            string narxi = lb_gam_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_gam_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_gam_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_big_gam_minus_Click(object sender, EventArgs e)
        {
            string name = lb_big_gam_name.Text;
            string narxi = lb_big_gam_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_big_gam_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_big_gam_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_chiz_minus_Click(object sender, EventArgs e)
        {
            string name = lb_chiz_name.Text;
            string narxi = lb_chiz_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_chiz_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_chiz_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_big_chiz_minus_Click(object sender, EventArgs e)
        {
            string name = lb_big_chiz_name.Text;
            string narxi = lb_big_chiz_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_big_chiz_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_big_chiz_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_donar_minus_Click(object sender, EventArgs e)
        {
            string name = lb_donar_name.Text;
            string narxi = lb_donar_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_donar_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_donar_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_shourma_minus_Click(object sender, EventArgs e)
        {
            string name = lb_shourma_name.Text;
            string narxi = lb_shourma_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_shourma_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_shourma_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_belissimo_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_belissimo_name.Text;
            string narxi = lb_pizza_belissimo_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_belissimo_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_assarti_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_assarti_name.Text;
            string narxi = lb_pizza_assarti_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_assarti_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_donar_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_donar_name.Text;
            string narxi = lb_pizza_donar_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_donar_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_napoli_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_napoli_name.Text;
            string narxi = lb_pizza_napoli_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_napoli_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_italy_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_italy_name.Text;
            string narxi = lb_pizza_italy_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_italy_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_margarita_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_margarita_name.Text;
            string narxi = lb_pizza_margarita_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_pizza_margarita_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pizza_belissimo_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_belissimo_name.Text;
            string narxi = lb_pizza_belissimo_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_belissimo_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_belissimo_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_assarti_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_assarti_name.Text;
            string narxi = lb_pizza_assarti_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_assarti_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_assarti_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_donar_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_donar_name.Text;
            string narxi = lb_pizza_donar_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_donar_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_donar_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_napoli_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_napoli_name.Text;
            string narxi = lb_pizza_napoli_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_napoli_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_napoli_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_italy_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_italy_name.Text;
            string narxi = lb_pizza_italy_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_italy_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_italy_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_pizza_margarita_minus_Click(object sender, EventArgs e)
        {
            string name = lb_pizza_margarita_name.Text;
            string narxi = lb_pizza_margarita_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_pizza_margarita_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_pizza_margarita_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_ketchup_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_ketchup_name.Text;
            string narxi = lb_ketchup_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_ketchup_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_cheese_sous_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_cheese_sous_name.Text;
            string narxi = lb_cheese_sous_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_cheese_sous_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_Moyanez_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_Moyanez_name.Text;
            string narxi = lb_Moyanez_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_Moyanez_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_chili_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_chili_name.Text;
            string narxi = lb_chili_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_chili_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_ketchup_minus_Click(object sender, EventArgs e)
        {
            string name = lb_ketchup_name.Text;
            string narxi = lb_ketchup_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_ketchup_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_ketchup_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_cheese_sous_minus_Click(object sender, EventArgs e)
        {
            string name = lb_cheese_sous_name.Text;
            string narxi = lb_cheese_sous_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_cheese_sous_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_cheese_sous_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_Moyanez_minus_Click(object sender, EventArgs e)
        {
            string name = lb_Moyanez_name.Text;
            string narxi = lb_Moyanez_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_Moyanez_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_Moyanez_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_chili_minus_Click(object sender, EventArgs e)
        {
            string name = lb_chili_name.Text;
            string narxi = lb_chili_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_chili_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_chili_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }



        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pepsi_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_Pepsi_name.Text;
            string narxi = lb_Pepsi_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_Pepsi_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btndrinks_Click(object sender, EventArgs e)
        {
            pn_drink.Visible = true;
            pn_desert.Visible = false;
        }

        private void btnfoods_Click(object sender, EventArgs e)
        {
            pn_drink.Visible = false;
            pn_desert.Visible = false;

        }

        private void btn_fanta_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_fanta_name.Text;
            string narxi = lb_fanta_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_fanta_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_cola_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_cola_name.Text;
            string narxi = lb_cola_naarxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_cola_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_limonchoy_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_limonchoy_name.Text;
            string narxi = lb_limonchoy_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_limonchoy_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_sharbat_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_sharbat_name.Text;
            string narxi = lb_sharbat_narxi.Text;




            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_sharbat_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_kofe_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_kofe_name.Text;
            string narxi = lb_kofe_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_kofe_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_pepsi_minus_Click(object sender, EventArgs e)
        {
            string name = lb_Pepsi_name.Text;
            string narxi = lb_Pepsi_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_Pepsi_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_Pepsi_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_fanta_minus_Click(object sender, EventArgs e)
        {
            string name = lb_fanta_name.Text;
            string narxi = lb_fanta_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_fanta_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_fanta_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_cola_minus_Click(object sender, EventArgs e)
        {
            string name = lb_cola_name.Text;
            string narxi = lb_cola_naarxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_cola_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_cola_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_limonchoy_minus_Click(object sender, EventArgs e)
        {
            string name = lb_limonchoy_name.Text;
            string narxi = lb_limonchoy_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_limonchoy_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_limonchoy_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_sharbat_minus_Click(object sender, EventArgs e)
        {
            string name = lb_sharbat_name.Text;
            string narxi = lb_sharbat_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_sharbat_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_sharbat_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_kofe_minus_Click(object sender, EventArgs e)
        {
            string name = lb_kofe_name.Text;
            string narxi = lb_kofe_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_kofe_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_kofe_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }



        private void btn_cheese_cake_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_cheese_cake_name.Text;
            string narxi = lb_cheese_cake_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_cheese_cake_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btndesert_Click(object sender, EventArgs e)
        {
            pn_desert.Visible = true;
        }

        private void btn_chocalate_desert_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_chocalate_desert_name.Text;
            string narxi = lb_chocalate_desert_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_chocalate_desert_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_apple_cake_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_apple_cake_name.Text;
            string narxi = lb_apple_cake_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_apple_cake_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_Cherrycake_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_Cherrycake_name.Text;
            string narxi = lb_Cherrycake_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_Cherrycake_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_black_cake_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_black_cake_name.Text;
            string narxi = lb_black_cake_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_black_cake_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_lemon_cake_pilus_Click(object sender, EventArgs e)
        {
            string name = lb_lemon_cake_name.Text;
            string narxi = lb_lemon_cake_narxi.Text;



            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave is null)
            {
                Zakas zakas = new Zakas();
                zakas.Name = name;
                zakas.Count = 0;
                zakas.Sum = 0;
                zakaslar.Add(zakas);
                isHave = zakas;
            }
            var index = zakaslar.IndexOf(isHave);
            zakaslar[index].Count += 1;
            zakaslar[index].Sum += int.Parse(narxi);

            Sum_total += int.Parse(narxi);
            lb_Sum.Text = Sum_total.ToString();

            lb_lemon_cake_hisob.Text = zakaslar[index].Count.ToString();

            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());

            }
        }

        private void btn_chocalate_desert_minus_Click(object sender, EventArgs e)
        {
            string name = lb_chocalate_desert_name.Text;
            string narxi = lb_chocalate_desert_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_chocalate_desert_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_chocalate_desert_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_apple_cake_minus_Click(object sender, EventArgs e)
        {
            string name = lb_apple_cake_name.Text;
            string narxi = lb_apple_cake_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_apple_cake_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_apple_cake_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_cheese_cake_pilus_Click_1(object sender, EventArgs e)
        {
            string name = lb_cheese_cake_name.Text;
            string narxi = lb_cheese_cake_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_cheese_cake_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_cheese_cake_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_Cherrycake_minus_Click(object sender, EventArgs e)
        {
            string name = lb_Cherrycake_name.Text;
            string narxi = lb_Cherrycake_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_Cherrycake_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_Cherrycake_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_black_cake_minus_Click(object sender, EventArgs e)
        {
            string name = lb_black_cake_name.Text;
            string narxi = lb_black_cake_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_black_cake_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_black_cake_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        private void btn_lemon_cake_minus_Click(object sender, EventArgs e)
        {
            string name = lb_lemon_cake_name.Text;
            string narxi = lb_lemon_cake_narxi.Text;

            var isHave = zakaslar.FirstOrDefault(x => x.Name == name);
            if (isHave != null)
            {
                if (isHave.Count > 1)
                {
                    var index = zakaslar.IndexOf(isHave);
                    zakaslar[index].Count -= 1;
                    zakaslar[index].Sum -= int.Parse(narxi);

                    lb_lemon_cake_hisob.Text = zakaslar[index].Count.ToString();

                }
                else
                {
                    zakaslar.Remove(isHave);
                    lb_lemon_cake_hisob.Text = "0";

                }
                Sum_total -= int.Parse(narxi);
                lb_Sum.Text = Sum_total.ToString();
            }
            datagr_zakas.Rows.Clear();
            foreach (var item in zakaslar)
            {
                datagr_zakas.Rows.Add(item.Name, item.Count.ToString(), item.Sum.ToString());
            }
        }

        int zakas_num = 0;
        private void btn_buy_Click(object sender, EventArgs e)
        {
            Zakas zakas = new Zakas();
            zakas.Count = 0;

            bool isNumeric = int.TryParse(txt_payment.Text, out _);
             if(lb_Sum.Text=="0")
            {
                MessageBox.Show("Please place an order");
            }
            else if(txt_payment.Text == "")
            {
                MessageBox.Show("Please enter payment");
            }
            else if (!isNumeric || int.Parse(txt_payment.Text) < int.Parse(lb_Sum.Text))
            {
                MessageBox.Show("Please enter the payment correctly");
            }
            else if(lb_Sum.Text != "0")
            {
                zakas_num += 1;
                lb_order_number.Text = zakas_num.ToString();

                datagr_zakas.Rows.Clear();
                txt_payment.Text = "0";
                lb_Sum.Text = "0";

                Sum_total = 0;


                lb_chocalate_desert_hisob.Text = "0";
            }
        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
