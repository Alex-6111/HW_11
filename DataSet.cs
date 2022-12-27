using System;
using System.Collections.Generic;
using System.Text;
using HW_11;

namespace HW_11
{
    public class DataSet
    {
        public List<Policeman> Policemans { get; }
        public List<Penalty> Penaltyes { get; }
        public List<Сitizen> Сitizens { get; }
        public DataSet()
        {
            Policemans = new List<Policeman>();
            Penaltyes = new List<Penalty>();
            Сitizens = new List<Сitizen>();

        }

    }
}
