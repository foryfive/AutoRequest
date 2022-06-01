using AutoResquest.Models.Entities;
using System.Collections.Generic;

namespace AutoResquest.Models
{
    public class Interval
    {

        public List<EInterval> GetEIntervals()
        {
            List<EInterval> list = new List<EInterval>();

            list.Add(new EInterval()
            {
                Text = "1 Minuto",
                Value = new System.TimeSpan(0, 1, 0)
            });

            list.Add(new EInterval()
            {
                Text = "2 Minutos",
                Value = new System.TimeSpan(0, 2, 0)
            });

            list.Add(new EInterval()
            {
                Text = "5 Minutos",
                Value = new System.TimeSpan(0, 5, 0)
            });

            list.Add(new EInterval()
            {
                Text = "15 Minutos",
                Value = new System.TimeSpan(0, 15, 0)
            });

            list.Add(new EInterval()
            {
                Text = "30 Minutos",
                Value = new System.TimeSpan(0, 30, 0)
            });

            list.Add(new EInterval()
            {
                Text = "45 Minutos",
                Value = new System.TimeSpan(0, 45, 0)
            });

            list.Add(new EInterval()
            {
                Text = "1 Hora",
                Value = new System.TimeSpan(1, 0, 0)
            });

            list.Add(new EInterval()
            {
                Text = "2 Horas",
                Value = new System.TimeSpan(2, 0, 0)
            });

            list.Add(new EInterval()
            {
                Text = "5 Horas",
                Value = new System.TimeSpan(3, 0, 0)
            });


            return list;
        }
    }

}
