using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Modélise un thermostat électronique contrôlant la température d'une pièce.
    /// </summary>
    public class Thermostat
    {
        #region Constantes
        /// ======= CHAMPS====== =================================
        public const int MIN_TEMPERATURE = 5;
        public const int MAX_TEMPERATURE = 35;
        public const int TEMPERATURE_INITIALE = 20;
        #endregion

        #region Propriété
        private int m_temperature;
        ///-------------------------------------------------------
        /// <summary>
        ///    Obtient ou définit la température du thermostat
        /// </summary>
        ///-------------------------------------------------------
        public int Temperature
        {
            get { return m_temperature; }
            set
            {
                // TODO Lever une exception ArgumentOutOfRangeException
                // si la nouvelle température est hors des limites permises

                // Attribuer la nouvelle température
               
            }
        }
        #endregion

        #region Constructeur
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance 
        ///   à la température initiale. 
        /// </summary>
        ///------------------------------------------------------------
        public Thermostat()
        {
            Temperature = TEMPERATURE_INITIALE;
        }
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance  
        ///   à la température pTemperature. 
        /// </summary>
        /// <param name="pTemperature">
        ///------------------------------------------------------------
        public Thermostat(int pTemperature)
        {
            Temperature = pTemperature;
        }
        #endregion

        #region Méthodes
        ///-------------------------------------------------------
        /// <summary>
        ///   Augmente la température courante d'un degré.
        /// </summary>
        ///-------------------------------------------------------
        public void AugmenterTemperature()
        {
            // TODO Lever une exception InvalidOperationException
            // si la température a déjà atteint la valeur maximale permise
            

            // TODO Augmenter la température de 1
            
        }
        ///-------------------------------------------------------
        /// <summary>
        ///   Diminue la température courante d'un degré.
        /// </summary>
        ///-------------------------------------------------------
        public void DiminuerTemperature()
        {
            // TODO Lever une exception InvalidOperationException
            // si la température a déjà atteint la valeur minimale permise
           

            // TODO Diminuer la température de 1
            
        }
        #endregion
    }
}
