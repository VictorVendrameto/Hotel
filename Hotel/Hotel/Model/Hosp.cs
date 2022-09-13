using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Model
{
    public class Hosp
    {
        int qnt_adult;
        Suit quarto_selec;


        public Suit QuartoSelec 
        { 
            get => QuartoSelec;
            set
            {
                if (value == null)
                    throw new Exception("Selecione um quarto");

                QuartoSelec = value;
            }
        }
        public int qnt_Kid { get; set; }
        public int qnt_Adult { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia 
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }

        public double TotalValue
        {
            get => ((qnt_Adult * QuartoSelec.DiaryAdult)
                + (qnt_Kid * QuartoSelec.DiaryKid)
                ) * Estadia;
        }
    }
}
