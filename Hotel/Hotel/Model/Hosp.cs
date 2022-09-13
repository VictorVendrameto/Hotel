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
            get => quarto_selec;
            set
            {
                if (value == null)
                    throw new Exception("Selecione um quarto");

                quarto_selec = value;
            }
        }
        public int qnt_Kid { get; set; }
        public int qnt_Adult 
        {
            get => qnt_adult;
                set
            {
                if (value == 0)
                    throw new Exception("Por favor, selecione a quantidade de adultos");
                
                qnt_adult = value;
            }
                }
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
