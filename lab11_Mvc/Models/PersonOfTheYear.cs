using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace lab11_Mvc.Models
{
	public class PersonOfTheYear
	{
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }


		public static List<PersonOfTheYear> GetStaff(int selectedStartYear, int selectedEndYear)
		{
			string[] PersonOfTheYear = File.ReadAllLines("App_Data/personOfTheYear.csv");

			return PersonOfTheYear
			   .Skip(1) // skip the header
			   .From(year in PersonOfTheYear)
			   .where(selectedStartYear<= year && selectedEndYear>=year)
			   .Select(personLine => personLine.Split(",")) // split line into cells
			   .Select(personCells => new PersonOfTheYear // make new Staff from cells
			   {
				    
				   Year= int.Parse(personCells[0]),
				   Honor= personCells[1],
				   Name= personCells[2],
				   Country= personCells[3],
				   BirthYear= int.Parse(personCells[4]), 
				   DeathYear= int.Parse(personCells[5]),
				   Title= personCells[6],
				   Category = personCells[7],
				   Context=personCells[6],
				  
			   })
			   .ToList();

		}

	}

}
