using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duomenu_tyryba_1uzd_test
{
    public partial class Form1 : Form
    {
        List<Viesbutis> viesbuciaiAll = new List<Viesbutis>() {
                           //pavadinimas,zvaigzdutes, atstumas, kaina, maitinimas, vertLan, balkonas, wifi, kondicionierius, neigaliems, augintinis, mbaras, parkingas, kacialka, virtuve
                new Viesbutis("Silken Al-Andalus Palace",  3,   1,   1,  1,   3, 0,   1,    1,  1,  1,  1,  1,  1,  0 ),
                new Viesbutis("Hotel Boutique Elvira Plaza",   2,   1  , 1 ,  1  , 3,  0   ,1 ,  1 ,  1   ,1 ,  1   ,1   ,0  , 0),
                new Viesbutis("Monte Carmelo", 3  , 1   ,2  , 1  , 3  , 0 ,  1  , 1,   1 ,  1  , 1 ,  0  , 0,   0),
                new Viesbutis("Casona de San Andrés" , 2 ,  0   ,1 , 1  , 3  , 0 , 1 , 1   ,1,   1   ,1 ,  0   ,0,  0),
                new Viesbutis("Hotel Alfonso XIII",    4  , 0  , 4  , 1  , 4  , 1  , 1,   1  , 1 , 1  ,1,   1 ,  1  , 0),
                new Viesbutis("Itaca Sevilla", 2 ,  0 ,  2 ,  1   ,3 ,  0  , 1 ,  1,   1 ,  1,   1 ,  1,   1,   0),
                new Viesbutis( "Hotel Casa Imperial",   3,   0,   2,   1,   3,   1,   1,   1,   1,   0,   0,   1,   1,   0),
                new Viesbutis("Hotel Sevilla Center",  3,   0,   1,   1,   3,   0,   1,   1,   1,   1,   1,   1,   1,   0),
                new Viesbutis("Hesperia Sevilla",  3,   0,   1,   1,   3,   0,   1,   1,   1,   1,   1,   1 ,  1,   0),
                new Viesbutis("Ribera de Triana Hotel",    3,   0,   2,   1,   3,   1,   1,   1,   1,   1,   1,   1,   1,   0),
                new Viesbutis("NH Collection Sevilla", 3,   0,   1,   1,   3,   0,   1,  1,   1,   1,   1,   1,   1,   0),
                new Viesbutis("Eurostars Regina",  2,   0,   2 ,  1 ,  3  , 0  , 1 ,  1 ,  1  , 1  , 1   ,1,   1  , 0),
                new Viesbutis("NH Sevilla Plaza de Armas", 3,   0 ,  2  , 1  , 3,  1 , 1  , 1 ,  1 , 1  ,1   ,1 ,  1 ,  0),
                new Viesbutis("Exe Sevilla Macarena" , 3,  0 ,  2 , 1 , 3  , 0 ,  1,   1 ,  1  , 1 ,  1, 0  , 1 ,  0),
                new Viesbutis("AC Hotel Sevilla Torneo",   3,   0 ,  1 ,  1 , 3 ,  1,   1 ,  1 , 1   ,1,   1,   1,  1,   0),
                new Viesbutis("M.A. Hotel Sevilla Congresos" , 3 ,  2 ,  1 ,  1,   3 ,  1  , 1 ,  1 ,  1,   1,   1,   1,   1,   0),
                new Viesbutis("Monte Triana", 3,  0  , 2 ,  1 ,  4,  0 ,  1  , 1,   1  , 1 ,  1 ,  1 , 1 ,  0),
                new Viesbutis("Pasarela" , 3 ,  0 , 2  , 1 ,  3 , 0  , 1 ,  1 ,  1 ,  1 ,  1 ,  1,   1  , 0),
                new Viesbutis("Hotel Fernando III" ,   3 ,  0 ,  2 ,  1  , 3,   0  , 1  , 1 , 1  , 1,   1 , 0  , 1 ,  0),
                new Viesbutis("Hotel Don Paco",    2,   0 ,  1  , 1,   3,   0,   1,   1,   1,   1,   1,   0,   0,   0),
                new Viesbutis("Melia Lebreros" ,   3,   0 ,  2,   1,   3 ,  0 ,  1 ,  1 ,  1 ,  1,   1  , 1 ,  0 ,  0),
                new Viesbutis("Hilton Garden Inn Sevilla", 3 ,  1  , 1 ,  1  , 3 ,  1,   1  , 1 , 1  , 1  ,1  , 1 ,  1  , 0),
                new Viesbutis("Suites Murillo"  ,  1 ,  0 ,  1 ,  1 ,  4 ,  1  , 1,   1 ,  1  , 1 ,  1 ,  1 ,  1  , 0),
                new Viesbutis("Hotel Bécquer", 3 ,  0 ,  1 ,  1 ,  4  , 0 ,  1 ,  1   ,1 ,  1 ,  1 ,  1 ,  1,   0),
                new Viesbutis("AACR Hotel Monteolivos" ,   2 ,  0 ,  1 ,  1,  3  , 0 ,  1  ,1 ,  1 ,  1 ,  1  , 0 ,  1 ,  0),
                new Viesbutis("Hotel Alcázar", 2 ,  0  , 1 ,  1 ,  3   ,0 ,  1,   1  , 1  , 1  , 1 ,  0  , 1 ,  0),
                new Viesbutis("Eurostars Torre Sevilla" , 4  , 0 , 2  , 1 ,  4  , 0  , 1,   1 ,  1,   1,   1,   0 ,  1,   0),
                new Viesbutis("Catalonia Giralda" ,3  , 0 ,  2,   1,   3,   0,   1,   1,   1,   1,   1,   0,   1,   0),
                new Viesbutis("Petit Palace Puerta de Triana", 2,   0,   2,   1,   4,   0,   1,   1,   1,   1,   1,   0,   1,   0),
                new Viesbutis("Hotel Bécquer"  , 3 ,  0 ,  1  , 1   ,4  , 0  , 1 ,  1 ,  1 ,  1 ,  1  , 1  , 0 ,  0),
                new Viesbutis("Hotel Gravina 51",  3 ,  0,   3  , 1 ,  4   ,0   ,1 ,  1 ,  1  , 1  , 1  , 1  , 1,   0),
                new Viesbutis("Gran Meliá Colon" , 4 ,  0  , 2 ,  1  , 4,  0 , 1 ,  1 , 1  , 1 ,  1,  0  , 1 ,  0),
                new Viesbutis("Hotel Casa 1800 Sevilla"  , 3,  0 ,  2 ,  1 ,  4 ,  1,  1,   1,   1,   1  , 1,   0 ,  1 ,  0),
                new Viesbutis("Sacristia de Santa Ana" ,   2 ,  0 ,  2 ,  1,   3  , 0,  1  , 1   ,1  , 1 ,  1 ,  1 ,  1,   0),
                new Viesbutis("Palacio Pinello"  , 3 , 0   ,3 ,  1 ,  4  , 0  , 1,  1  , 1   ,1 ,  1 ,  1  , 1  , 0),
                new Viesbutis("San Gil"  , 3 ,  0 ,  2,  1 ,  3 ,  1 ,  1 ,  1   ,1 ,  1 , 1  , 1  , 0 ,  0),
                new Viesbutis("Hotel Doña Lin"   , 1 , 0  , 1 ,  1 ,  3   ,0 ,  1 ,  1 ,  1  , 1 ,  1 ,  0 ,  0  , 0),
                new Viesbutis("Las Casas de El Arenal" ,   3 ,  0,   2  , 1  , 4 ,  0  , 1 ,  1 ,  1 , 1  , 1  , 1,  0 ,  0),
                new Viesbutis("Hotel Boutique Elvira Plaza",  2  , 0,  2 ,  1,   3 ,  1 ,  1,   1 ,  1,   1  , 1  , 1 ,  0 ,  0),
                new Viesbutis("Hotel Sevilla",  1  , 0,  2 ,  1,   2 ,  0 ,  1,   1 ,  1,   1  , 1  , 0 ,  0 ,  0),
                new Viesbutis("SINTETINIS",  4  , 4,  4 ,  4,   4 ,  1 ,  1,   1 ,  1,   1  , 1  , 1 ,  1 ,  1),
                new Viesbutis("SINTETINIS2",  0  , 0,  0 ,  0,   0 ,  0 ,  0,   0 ,  0,   0  , 0  , 0 ,  0 ,  0),
                new Viesbutis("SINTETINIS3",  4  , 4,  4 ,  4,   4 ,  0 ,  0,   0 ,  0,   0  , 0  , 0 ,  0 ,  0),
                new Viesbutis("SINTETINIS4",  0  , 0,  0 ,  0,   0 ,  1 ,  1,   1 ,  1,   1  , 1  , 1 ,  1 ,  1),
            };
        List<Viesbutis> viesbuciaiZeroOne = new List<Viesbutis>();

        double priceValueInput, starsValueInput, distanceValueInput, mealsValueInput, rateValueInput, balconyValueInput,
            wifiValueInput, conditionerValueInput, disabledPersonsValueInput, petValueInput, minibarValueInput, parkingValueInput, gymValueInput, kitchenValueInput;

        public Form1()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printHotelList();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (price_CB.SelectedIndex > -1 && stars_CB.SelectedIndex > -1 && distance_CB.SelectedIndex > -1 && meals_CB.SelectedIndex > -1 && rate_CB.SelectedIndex > -1)
            {
                DBhotelValuesZeroOne();
                getUserInputValuesZeroOne();
                txt_optimalEuclidean.Text = "";
                txt_optimalManhattan.Text = "";

                List<Viesbutis> calculationsEuclidean = new List<Viesbutis>();
                List<Viesbutis> calculationsManhattan = new List<Viesbutis>();

                foreach (var vies in viesbuciaiZeroOne)
                {
                    double calcManhattan = vies.calculateOptimalManhattan(starsValueInput, distanceValueInput, priceValueInput, mealsValueInput, rateValueInput, balconyValueInput,
                        wifiValueInput, conditionerValueInput, disabledPersonsValueInput, petValueInput, minibarValueInput, parkingValueInput,
                        gymValueInput, kitchenValueInput, vies);

                    vies.dManhattan = calcManhattan;
                    calculationsManhattan.Add(vies);


                    double calcEuclidean = vies.calculateOptimalEuclidean(starsValueInput, distanceValueInput, priceValueInput, mealsValueInput, rateValueInput, balconyValueInput,
                        wifiValueInput, conditionerValueInput, disabledPersonsValueInput, petValueInput, minibarValueInput, parkingValueInput,
                        gymValueInput, kitchenValueInput, vies);

                    vies.dEuclidean = calcEuclidean;
                    calculationsEuclidean.Add(vies);
                }
                calculationsEuclidean = calculationsEuclidean.OrderBy(a => a.dEuclidean).ToList();
                calculationsManhattan = calculationsManhattan.OrderBy(a => a.dManhattan).ToList();

                txt_optimalEuclidean.Text = "Euklidas Jums rekomenduoja:\n" + "1) " + calculationsEuclidean[0].Pavadinimas + " " + calculationsEuclidean[0].dEuclidean + "\n" +
                                                                              "2) " + calculationsEuclidean[1].Pavadinimas + " " + calculationsEuclidean[1].dEuclidean + "\n" +
                                                                              "3) " + calculationsEuclidean[2].Pavadinimas + " " + calculationsEuclidean[2].dEuclidean + "\n" +
                                                                              "4) " + calculationsEuclidean[3].Pavadinimas + " " + calculationsEuclidean[3].dEuclidean + "\n" +
                                                                              "5) " + calculationsEuclidean[4].Pavadinimas + " " + calculationsEuclidean[4].dEuclidean;

                txt_optimalManhattan.Text = "Manhatanas Jums rekomenduoja:\n" + "1) " + calculationsManhattan[0].Pavadinimas + " " + calculationsManhattan[0].dManhattan + "\n" +
                                                                              "2) " + calculationsManhattan[1].Pavadinimas + " " + calculationsManhattan[1].dManhattan + "\n" +
                                                                              "3) " + calculationsManhattan[2].Pavadinimas + " " + calculationsManhattan[2].dManhattan + "\n" +
                                                                              "4) " + calculationsManhattan[3].Pavadinimas + " " + calculationsManhattan[3].dManhattan + "\n" +
                                                                              "5) " + calculationsManhattan[4].Pavadinimas + " " + calculationsManhattan[4].dManhattan;

            }
            else
            {
                MessageBox.Show("Įveskite reikiamus duomenis",
                    "Trūksta duomenų");
            }

        }

        private void DBhotelValuesZeroOne()
        {

            viesbuciaiZeroOne.Clear();
            // pakeicia DUOMENU BAZES viesbuciu reiksmes tarp 0 ir 1
            foreach (Viesbutis h in viesbuciaiAll)
            {
                int starsIndex = Convert.ToInt32(h.Zvaigzdutes);
                double starsValue;
                if (starsIndex == 0)
                {
                    starsValue = 1;
                }
                else if (starsIndex == 1)
                {
                    starsValue = 0.8;
                }
                else if (starsIndex == 2)
                {
                    starsValue = 0.6;
                }
                else if (starsIndex == 3)
                {
                    starsValue = 0.4;
                }
                else if (starsIndex == 4)
                {
                    starsValue = 0.2;
                }
                else
                {
                    starsValue = 0;
                }


                int distanceIndex = Convert.ToInt32(h.Atstumas_iki_centro);
                double distanceValue;
                if (distanceIndex == 0)
                {
                    distanceValue = 1;
                }
                else if (distanceIndex == 1)
                {
                    distanceValue = 0.8;
                }
                else if (distanceIndex == 2)
                {
                    distanceValue = 0.6;
                }
                else if (distanceIndex == 3)
                {
                    distanceValue = 0.4;
                }
                else if (distanceIndex == 4)
                {
                    distanceValue = 0.2;
                }
                else
                {
                    distanceValue = 0;
                }


                int priceIndex = Convert.ToInt32(h.Vidutine_kaina);
                double priceValue;
                if (priceIndex == 0)
                {
                    priceValue = 1;
                }
                else if (priceIndex == 1)
                {
                    priceValue = 0.8;
                }
                else if (priceIndex == 2)
                {
                    priceValue = 0.6;
                }
                else if (priceIndex == 3)
                {
                    priceValue = 0.4;
                }
                else if (priceIndex == 4)
                {
                    priceValue = 0.2;
                }
                else
                {
                    priceValue = 0;
                }


                int mealsIndex = Convert.ToInt32(h.maitinimas);
                double mealsValue;
                if (mealsIndex == 0)
                {
                    mealsValue = 1;
                }
                else if (mealsIndex == 1)
                {
                    mealsValue = 0.8;
                }
                else if (mealsIndex == 2)
                {
                    mealsValue = 0.6;
                }
                else if (mealsIndex == 3)
                {
                    mealsValue = 0.4;
                }
                else if (mealsIndex == 4)
                {
                    mealsValue = 0.2;
                }
                else
                {
                    mealsValue = 0;
                }

                int guestRatingIndex = Convert.ToInt32(h.lankytoju_balas);
                double guestRatingValue;
                if (guestRatingIndex == 0)
                {
                    guestRatingValue = 1;
                }
                else if (guestRatingIndex == 1)
                {
                    guestRatingValue = 0.8;
                }
                else if (guestRatingIndex == 2)
                {
                    guestRatingValue = 0.6;
                }
                else if (guestRatingIndex == 3)
                {
                    guestRatingValue = 0.4;
                }
                else if (guestRatingIndex == 4)
                {
                    guestRatingValue = 0.2;
                }
                else
                {
                    guestRatingValue = 0;
                }

                double balconyValue;
                if (h.balkonas == 1)
                {
                    balconyValue = 1;
                }
                else
                {
                    balconyValue = 0;
                }

                double wifiValue;
                if (h.wifi == 1)
                {
                    wifiValue = 1;
                }
                else
                {
                    wifiValue = 0;
                }

                double conditionerValue;
                if (h.kondicionierius == 1)
                {
                    conditionerValue = 1;
                }
                else
                {
                    conditionerValue = 0;
                }

                double disabledPersonsValue;
                if (h.pritaikymas_neigaliems == 1)
                {
                    disabledPersonsValue = 1;
                }
                else
                {
                    disabledPersonsValue = 0;
                }

                double petValue;
                if (h.leidziamas_augintinis == 1)
                {
                    petValue = 1;
                }
                else
                {
                    petValue = 0;
                }

                double minibarValue;
                if (h.minibaras == 1)
                {
                    minibarValue = 1;
                }
                else
                {
                    minibarValue = 0;
                }

                double parkingValue;
                if (h.parkingo_vieta == 1)
                {
                    parkingValue = 1;
                }
                else
                {
                    parkingValue = 0;
                }

                double gymValue;
                if (h.kacialka == 1)
                {
                    gymValue = 1;
                }
                else
                {
                    gymValue = 0;
                }

                double kitchenValue;
                if (h.virtuvele == 1)
                {
                    kitchenValue = 1;
                }
                else
                {
                    kitchenValue = 0;
                }
                Viesbutis ho = new Viesbutis(h.Pavadinimas, starsValue, distanceValue, priceValue, mealsValue, guestRatingValue, balconyValue, wifiValue, conditionerValue,
                    disabledPersonsValue, petValue, minibarValue, parkingValue, gymValue, kitchenValue);
                viesbuciaiZeroOne.Add(ho);
            }
        }

        //spausdinti i lentele db viesbucius
        private void printHotelList()
        {
            int counter = 1;
            HotelsData.View = View.Details;
            HotelsData.Columns.Add("Eil. Nr.");
            HotelsData.Columns.Add("Pavadinimas     ");
            HotelsData.Columns.Add("Reitingas");
            HotelsData.Columns.Add("Atstumas iki centro");
            HotelsData.Columns.Add("Kaina");

            HotelsData.Columns.Add("Maitinimas");
            HotelsData.Columns.Add("Lankytojų balas");

            HotelsData.Columns.Add("Balkonas");
            HotelsData.Columns.Add("Wi-Fi");
            HotelsData.Columns.Add("Kondicionierius");
            HotelsData.Columns.Add("Pritaikymas neįgaliesiems");
            HotelsData.Columns.Add("Leidžiamas augintinis");
            HotelsData.Columns.Add("Minibaras");
            HotelsData.Columns.Add("Parkingo vieta");
            HotelsData.Columns.Add("Treniruoklių salė");
            HotelsData.Columns.Add("Mini virtuvė");


            //HotelsData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            HotelsData.Columns[0].Width = 35;
            HotelsData.Columns[1].Width = 180;
            HotelsData.Columns[2].Width = 80;
            HotelsData.Columns[3].Width = 115;
            HotelsData.Columns[4].Width = 110;
            HotelsData.Columns[5].Width = 70;
            HotelsData.Columns[6].Width = 95;
            HotelsData.Columns[7].Width = 70;
            HotelsData.Columns[8].Width = 40;
            HotelsData.Columns[9].Width = 90;
            HotelsData.Columns[10].Width = 130;
            HotelsData.Columns[11].Width = 115;
            HotelsData.Columns[12].Width = 65;
            HotelsData.Columns[13].Width = 85;
            HotelsData.Columns[14].Width = 110;
            HotelsData.Columns[15].Width = 70;

            foreach (Viesbutis hotel in viesbuciaiAll)
            {
                int indexReitingas = Convert.ToInt32(hotel.Zvaigzdutes);
                int indexAtstumas = Convert.ToInt32(hotel.Atstumas_iki_centro);
                int indexKaina = Convert.ToInt32(hotel.Vidutine_kaina);
                int indexMaitinimas = Convert.ToInt32(hotel.maitinimas);
                int indexLankytojuBalas = Convert.ToInt32(hotel.lankytoju_balas);

                string reitingas = stars_CB.Items[indexReitingas].ToString();
                string atstumas = distance_CB.Items[indexAtstumas].ToString();
                string kaina = price_CB.Items[indexKaina].ToString();
                string maitinimas = meals_CB.Items[indexMaitinimas].ToString();
                string lankytojuBalas = rate_CB.Items[indexLankytojuBalas].ToString();

                string balkonas = string.Empty;
                string wifi = string.Empty;
                string kondicionierius = string.Empty;
                string kambarys_neigaliems = string.Empty;
                string augintinis = string.Empty;
                string minibaras = string.Empty;
                string parkingas = string.Empty;
                string kacialka = string.Empty;
                string virtuve = string.Empty;

                if (hotel.balkonas.Equals(1))
                {
                    balkonas = "+";
                }
                else
                {
                    balkonas = "-";
                }

                if (hotel.wifi.Equals(1))
                {
                    wifi = "+";
                }
                else
                {
                    wifi = "-";
                }

                if (hotel.kondicionierius.Equals(1))
                {
                    kondicionierius = "+";
                }
                else
                {
                    kondicionierius = "-";
                }

                if (hotel.pritaikymas_neigaliems.Equals(1))
                {
                    kambarys_neigaliems = "+";
                }
                else
                {
                    kambarys_neigaliems = "-";
                }

                if (hotel.leidziamas_augintinis.Equals(1))
                {
                    augintinis = "+";
                }
                else
                {
                    augintinis = "-";
                }

                if (hotel.minibaras.Equals(1))
                {
                    minibaras = "+";
                }
                else
                {
                    minibaras = "-";
                }

                if (hotel.parkingo_vieta.Equals(1))
                {
                    parkingas = "+";
                }
                else
                {
                    parkingas = "-";
                }

                if (hotel.kacialka.Equals(1))
                {
                    kacialka = "+";
                }
                else
                {
                    kacialka = "-";
                }

                if (hotel.virtuvele.Equals(1))
                {
                    virtuve = "+";
                }
                else
                {
                    virtuve = "-";
                }

                HotelsData.Items.Add(new ListViewItem(new string[] {counter.ToString(), hotel.Pavadinimas, reitingas, atstumas, kaina, maitinimas, lankytojuBalas,
                                                                    balkonas, wifi, kondicionierius, kambarys_neigaliems, augintinis, minibaras, parkingas, kacialka, virtuve}));
                HotelsData.Items.Add(new ListViewItem(new string[] { }));
                counter++;
            }

        }

        //funkcija pakeicia vartotojo ivesto viesbucio duomenis tarp 0 ir 1
        private void getUserInputValuesZeroOne()
        {
            int priceIndex = price_CB.SelectedIndex;
            if (priceIndex == 0)
                priceValueInput = 1;
            else if (priceIndex == 1)
                priceValueInput = 0.8;
            else if (priceIndex == 2)
                priceValueInput = 0.6;
            else if (priceIndex == 3)
                priceValueInput = 0.4;
            else if (priceIndex == 4)
                priceValueInput = 0.2;
            else
                priceValueInput = 0;


            int starsIndex = stars_CB.SelectedIndex;
            if (starsIndex == 0)
                starsValueInput = 1;
            else if (starsIndex == 1)
                starsValueInput = 0.8;
            else if (starsIndex == 2)
                starsValueInput = 0.6;
            else if (starsIndex == 3)
                starsValueInput = 0.4;
            else if (starsIndex == 4)
                starsValueInput = 0.2;
            else
                starsValueInput = 0;


            int distanceIndex = distance_CB.SelectedIndex;
            if (distanceIndex == 0)
                distanceValueInput = 1;
            else if (distanceIndex == 1)
                distanceValueInput = 0.8;
            else if (distanceIndex == 2)
                distanceValueInput = 0.6;
            else if (distanceIndex == 3)
                distanceValueInput = 0.4;
            else if (distanceIndex == 4)
                distanceValueInput = 0.2;
            else
                distanceValueInput = 0;


            int mealsIndex = meals_CB.SelectedIndex;
            if (mealsIndex == 0)
                mealsValueInput = 1;
            else if (mealsIndex == 1)
                mealsValueInput = 0.8;
            else if (mealsIndex == 2)
                mealsValueInput = 0.6;
            else if (mealsIndex == 3)
                mealsValueInput = 0.4;
            else if (mealsIndex == 4)
                mealsValueInput = 0.2;
            else
                mealsValueInput = 0;


            int rateIndex = rate_CB.SelectedIndex;
            if (rateIndex == 0)
                rateValueInput = 1;
            else if (rateIndex == 1)
                rateValueInput = 0.8;
            else if (rateIndex == 2)
                rateValueInput = 0.6;
            else if (rateIndex == 3)
                rateValueInput = 0.4;
            else if (rateIndex == 4)
                rateValueInput = 0.2;
            else
                rateValueInput = 0;


            if (balkonas_C.Checked)
                balconyValueInput = 1;
            else
                balconyValueInput = 0;

            if (wifi_C.Checked)
                wifiValueInput = 1;
            else
                wifiValueInput = 0;

            if (kondicionierius_C.Checked)
                conditionerValueInput = 1;
            else
                conditionerValueInput = 0;

            if (neigaliems_C.Checked)
                disabledPersonsValueInput = 1;
            else
                disabledPersonsValueInput = 0;

            if (gyvunai_C.Checked)
                petValueInput = 1;
            else
                petValueInput = 0;

            if (minibaras_C.Checked)
                minibarValueInput = 1;
            else
                minibarValueInput = 0;

            if (parkingas_C.Checked)
                parkingValueInput = 1;
            else
                parkingValueInput = 0;

            if (kacialka_C.Checked)
                gymValueInput = 1;
            else
                gymValueInput = 0;

            if (virtuve_C.Checked)
                kitchenValueInput = 1;
            else
                kitchenValueInput = 0;

        }



    }
}
