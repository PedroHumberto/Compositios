using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composição.Entities.Enums;

namespace Composição.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departments Departments { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //instanciar para garantir que ela não seja null

        
        public Worker() 
        {
        }

        //não instanciar uma lista ao construtor, pois a lista representa "para muitos", a lista começa vazia, depois adiciona objetos conforme necessidade
        public Worker(string name, WorkerLevel level, double baseSalary, Departments departments)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departments = departments;
        }

        public void AddContract(HourContract contract) 
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) 
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) 
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) 
            {
                if (contract.Date.Year == year && contract.Date.Month == month) 
                {
                    sum += contract.TotalValue();
                }                
            }
            return sum;


        }


    }
}
