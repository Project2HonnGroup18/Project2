using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace AcademicReferenceManager.Repositories.Data
{
    public class DbContext
    {
        private MongoClient client = new MongoClient(
            "mongodb+srv://armuser:<arm123>@arm-cluster-kyji3.mongodb.net/test?retryWrites=true&w=majority"
        );

        

        
    }
}