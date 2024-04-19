using System;


namespace CSharpJourney{

    /*
      I will be using the Installer class 
      to understand composition, the installer class too
      needs a logging service. It doesn't make sense to extend an installer class
      from a logging class. It makes more sense to compose the logging service in the
      installer class.
  */

    class Installer{


        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger; 
        }


        public void Install(){
            _logger.Log("Installing, please be patient....");
        }

    }



}