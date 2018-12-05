using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duomenu_tyryba_1uzd_test
{
    class Viesbutis
    {
        public string Pavadinimas { get; set; }
        public double Zvaigzdutes { get; set; }
        public double Atstumas_iki_centro { get; set; }
        public double Vidutine_kaina { get; set; }
        public double dEuclidean { get; set; }
        public double dManhattan { get; set; }

        public double maitinimas { get; set; }
        public double lankytoju_balas { get; set; }
        public double balkonas { get; set; }
        public double wifi { get; set; }
        public double kondicionierius { get; set; }
        public double pritaikymas_neigaliems { get; set; }
        public double leidziamas_augintinis { get; set; }
        public double minibaras { get; set; }
        public double parkingo_vieta { get; set; }
        public double kacialka { get; set; }
        public double virtuvele { get; set; }


        public Viesbutis(string Pavadinimas, double Zvaigzdutes, double Atstumas_iki_centro, double Vidutine_kaina, double dEuclidean, double dManhattan,
            double maitinimas, double lankytoju_balas, double balkonas, double wifi, double kondicionierius, double pritaikymas_neigaliems,
            double leidziamas_augintinis, double minibaras, double parkingo_vieta, double kacialka, double virtuvele)
        {
            this.Pavadinimas = Pavadinimas;
            this.Zvaigzdutes = Zvaigzdutes;
            this.Atstumas_iki_centro = Atstumas_iki_centro;
            this.Vidutine_kaina = Vidutine_kaina;
            this.dEuclidean = dEuclidean;
            this.dManhattan = dManhattan;


            this.maitinimas = maitinimas;
            this.lankytoju_balas = lankytoju_balas;
            this.balkonas = balkonas;
            this.wifi = wifi;
            this.kondicionierius = kondicionierius;
            this.pritaikymas_neigaliems = pritaikymas_neigaliems;
            this.leidziamas_augintinis = leidziamas_augintinis;
            this.minibaras = minibaras;
            this.parkingo_vieta = parkingo_vieta;
            this.kacialka = kacialka;
            this.virtuvele = virtuvele;
        }


        public Viesbutis(string Pavadinimas, double Zvaigzdutes, double Atstumas_iki_centro, double Vidutine_kaina,
            double maitinimas, double lankytoju_balas, double balkonas, double wifi, double kondicionierius, double pritaikymas_neigaliems,
            double leidziamas_augintinis, double minibaras, double parkingo_vieta, double kacialka, double virtuvele)
        {
            this.Pavadinimas = Pavadinimas;
            this.Zvaigzdutes = Zvaigzdutes;
            this.Atstumas_iki_centro = Atstumas_iki_centro;
            this.Vidutine_kaina = Vidutine_kaina;

            this.maitinimas = maitinimas;
            this.lankytoju_balas = lankytoju_balas;
            this.balkonas = balkonas;
            this.wifi = wifi;
            this.kondicionierius = kondicionierius;
            this.pritaikymas_neigaliems = pritaikymas_neigaliems;
            this.leidziamas_augintinis = leidziamas_augintinis;
            this.minibaras = minibaras;
            this.parkingo_vieta = parkingo_vieta;
            this.kacialka = kacialka;
            this.virtuvele = virtuvele;
        }



        public double calculateOptimalEuclidean(double zvaigzdutes, double atstumas, double kaina, double maitinimas, double ivertinimas, double balkonas, double wifi,
            double kondicionierius, double neigaliems, double augintinis, double minibaras, double parkingas, double kacialka, double virtuvele, Viesbutis V)
        {
            double d = Math.Sqrt(
                Math.Pow((zvaigzdutes - V.Zvaigzdutes), 2) +
                Math.Pow((atstumas - V.Atstumas_iki_centro), 2) +
                Math.Pow((kaina - V.Vidutine_kaina), 2) +
                Math.Pow((maitinimas - V.maitinimas), 2) +
                Math.Pow((ivertinimas - V.lankytoju_balas), 2) +
                Math.Pow((balkonas - V.balkonas), 2) +
                Math.Pow((wifi - V.wifi), 2) +
                Math.Pow((kondicionierius - V.kondicionierius), 2) +
                Math.Pow((neigaliems - V.pritaikymas_neigaliems), 2) +
                Math.Pow((augintinis - V.leidziamas_augintinis), 2) +
                Math.Pow((minibaras - V.minibaras), 2) +
                Math.Pow((parkingas - V.parkingo_vieta), 2) +
                Math.Pow((kacialka - V.kacialka), 2) +
                Math.Pow((virtuvele - V.virtuvele), 2)
                );
            return d;
        }


        public double calculateOptimalManhattan(double zvaigzdutes, double atstumas, double kaina, double maitinimas, double ivertinimas, double balkonas, double wifi,
            double kondicionierius, double neigaliems, double augintinis, double minibaras, double parkingas, double kacialka, double virtuvele, Viesbutis V)
        {

            double zvaigzdutesModulated = zvaigzdutes - V.Zvaigzdutes;
            if (zvaigzdutesModulated < 0)
                zvaigzdutesModulated *= -1;

            double atstumasModulated = atstumas - V.Atstumas_iki_centro;
            if (atstumasModulated < 0)
                atstumasModulated *= -1;

            double kainaModulated = kaina - V.Vidutine_kaina;
            if (kainaModulated < 0)
                kainaModulated *= -1;

            double maitinimasModulated = maitinimas - V.maitinimas;
            if (maitinimasModulated < 0)
                maitinimasModulated *= -1;

            double ivertinimasModulated = ivertinimas - V.lankytoju_balas;
            if (ivertinimasModulated < 0)
                ivertinimasModulated *= -1;

            double balkonasModulated = balkonas - V.balkonas;
            if (balkonasModulated < 0)
                balkonasModulated *= -1;

            double wifiModulated = wifi - V.wifi;
            if (wifiModulated < 0)
                wifiModulated *= -1;

            double kondicionieriusModulated = kondicionierius - V.kondicionierius;
            if (kondicionieriusModulated < 0)
                kondicionieriusModulated *= -1;

            double neigaliemsModulated = neigaliems - V.pritaikymas_neigaliems;
            if (neigaliemsModulated < 0)
                neigaliemsModulated *= -1;

            double augintinisModulated = augintinis - V.leidziamas_augintinis;
            if (augintinisModulated < 0)
                augintinisModulated *= -1;

            double minibarasModulated = minibaras - V.minibaras;
            if (minibarasModulated < 0)
                minibarasModulated *= -1;

            double parkingasModulated = parkingas - V.parkingo_vieta;
            if (parkingasModulated < 0)
                parkingasModulated *= -1;

            double kacialkaModulated = kacialka - V.kacialka;
            if (kacialkaModulated < 0)
                kacialkaModulated *= -1;

            double virtuveModulated = virtuvele - V.virtuvele;
            if (virtuveModulated < 0)
                virtuveModulated *= -1;


            double d = zvaigzdutesModulated + atstumasModulated + kainaModulated + maitinimasModulated + ivertinimasModulated + balkonasModulated + wifiModulated +
                kondicionieriusModulated + neigaliemsModulated + augintinisModulated + minibarasModulated + parkingasModulated + kacialkaModulated + virtuveModulated;
            return d;
        }

        

    }
}
