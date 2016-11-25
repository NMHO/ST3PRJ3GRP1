using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace Interfaces
{
    public interface PL
    {
        void startGUI();
    } 

    /// <summary>
    /// Interface som angiver en metode til indlæsning af input
    /// </summary>
    public interface IReadInput
    {
        List<double> ReadInput(int samples);
    }

    public interface IObserver
    {
        void Update(List<double> sekvens);
    }

    /*
    public interface LL
    {
    }
    

    public interface DL
    {
    }
    */
}
