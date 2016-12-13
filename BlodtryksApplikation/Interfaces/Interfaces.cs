using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace Interfaces
{
    /// <summary>
    /// Interface til brug i præsentationslag
    /// </summary>
    public interface PL
    {
        /// <summary>
        /// Metode der skal implementeres så hovedvinduet startes
        /// </summary>
        void startGUI();
    } 

    /// <summary>
    /// Interface som angiver en metode til indlæsning af input
    /// </summary>
    public interface IReadInput
    {
        /// <summary>
        /// Metode der returnerer en liste, som indeholder det indlæste input 
        /// </summary>
        /// <param name="samples">Angiver hvor  mage samples der skal indlæses</param>
        /// <returns></returns>
        List<double> ReadInput(int samples);
    }

    /// <summary>
    /// Observer-interface for logiklaget
    /// </summary>
    public interface IObserverLL
    {
        /// <summary>
        /// Update-metode
        /// </summary>
        /// <param name="sekvens">Liste med nuværende sekvens som parameter</param>
        void Update(List<double> sekvens);
    }

    /// <summary>
    /// Observer-interface for præsentationslaget
    /// </summary>
    public interface IObserverPL
    {
        /// <summary>
        /// Update-metode
        /// </summary>
        void Update();
    }
}
