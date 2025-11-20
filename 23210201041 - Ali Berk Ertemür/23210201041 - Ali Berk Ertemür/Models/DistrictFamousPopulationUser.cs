using _23210201041___Ali_Berk_Ertemür.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23210201041___Ali_Berk_Ertemür.Models
{
        public class DistrictFamousPopulationUser
        {
            //FamousPlaces District User Population tablolarını toplu olarak view e aktarmak
            public DistrictFamousPopulationUser(OdevContext context)
            {

                TableDistricts = context.Districts.ToList();
                TableFamousPlaces = context.FamousPlaces.ToList();
                TableUsers = context.Users.ToList();
                TablePopulations = context.Populations.ToList();
                TableSliders = context.Sliders.ToList();
            }
            public List<TableDistrict> TableDistricts { get; set; } = new List<TableDistrict>();
            public List<TableFamousPlace> TableFamousPlaces { get; set; } = new List<TableFamousPlace>();
            public List<TablePopulation> TablePopulations { get; set; } = new List<TablePopulation>();
            public List<TableUser> TableUsers { get; set; } = new List<TableUser>();
            public List<TableSlider> TableSliders { get; set; } = new List<TableSlider>();


        }
    }
