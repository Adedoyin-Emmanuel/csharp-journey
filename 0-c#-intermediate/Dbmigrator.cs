using System;


namespace CSharpJourney{
    
    /*
        I will be using the Dbmigrator class 
        to understand composition, the dbmigrator class 
        should be able to log, it is responsible for migrating 
        our database. I think of the composition as a service based approach

        where each module can need several services but that module shouldn't be
        inherited from that service.
    */

    class Dbmigrator{

        private readonly Logger _logger;
        public Dbmigrator(Logger logger)
        {
            _logger = logger;
        }


        public void MigrateDatabase(){

            _logger.Log("Migrating database");
        }
    }
}