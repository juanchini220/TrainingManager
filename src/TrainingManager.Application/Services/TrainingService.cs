using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Domain.Entities;


namespace TrainingManager.Application.Services;

public class TrainingService
{
    public IEnumerable<Training> GetTrainings()
    {
        return new List<Training>
        {
            new()
            {
                Id = 1,
                Name = "Push Day"
            },
            new ()
            {
                Id = 2,
                Name = "Pull Day"
            }
        };



    }
}