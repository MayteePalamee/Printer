using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Printers
    {
        /**
      * event delegate.
      * Declare the event using EventHandler<T>
      **/

        public event EventHandler<Events> RaiseEvents;

        /**
         * delegate method handle raise event
         **/
        protected virtual void OnRaiseEvent(Events e)
        {
            RaiseEvents?.Invoke(this, e);
        }

        Status status;
        public Status Connect()
        {
            status = new Status();
            try
            {

            }catch(Exception e)
            {

            }
            return status;
        }
        public Boolean Printing()
        {
            try
            {

            }catch(Exception e)
            {

            }
            return true;
        }
    }
}
