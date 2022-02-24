using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //data transfer object
    internal class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDAO )
        {
            this.serialNumber = stateCodeDAO.serialNumber;
            this.stateName = stateCodeDAO.stateName;
            this.tin = stateCodeDAO.tin;
            this.stateCode = stateCodeDAO.stateCode;
        }
        public CensusDTO(CensusdataDAO censusDAO)
        {
            this.state = censusDAO.state;
            this.population = censusDAO.population;
            this.area = censusDAO.area;
            this.density = censusDAO.density;
        }
    }

    public class CensusdataDAO
    {
        internal string state;
        internal long population;
        internal long area;
        internal long density;
    }
}
