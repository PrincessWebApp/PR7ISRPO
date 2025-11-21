using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    /// <summary>
    /// Класс Builder содержит методы для расчёта строительных материалов и проверки VIN-номера.
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Проверяет VIN-номер на правильность по длине строки.
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        public bool ProveritVIN(string vin)
        {
            if (string.IsNullOrEmpty(vin))
                return false;
            return vin.Length == 17;
        }
        /// <summary>
        /// Рассчитывает количество рулонов обоев для оклейки комнаты.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="height"></param>
        /// <param name="windowHeight"></param>
        /// <param name="windowWidth"></param>
        /// <param name="doorHeight"></param>
        /// <param name="doorWidth"></param>
        /// <param name="rollWidth"></param>
        /// <returns></returns>
        public int PasteWallpaper(double width, double length, double height, double windowHeight, double windowWidth, double doorHeight, double doorWidth, double rollWidth)
        {
            double perimeter = 2 * (width + length);
            double totalArea = perimeter * height;
            double windowArea = windowHeight * windowWidth;
            double doorArea = doorHeight * doorWidth;
            double usableArea = totalArea - windowArea - doorArea;

            double rollsCount = usableArea / (rollWidth * 10.5);
            return (int)Math.Ceiling(rollsCount);
        }
        /// <summary>
        /// Рассчитывает количество метров линолеума для покрытия пола.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="linoleumWidth"></param>
        /// <returns></returns>
        public double LayLinoleum(double width, double length, double linoleumWidth)
        {
            double roomArea = width * length;
            double linoleumLength = roomArea / linoleumWidth;
            return Math.Ceiling(linoleumLength * 2) / 2; // округление до 0.5 метра
        }
        /// <summary>
        /// Рассчитывает количество банок краски для покраски потолка.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="paintConsumption"></param>
        /// <param name="canVolume"></param>
        /// <returns></returns>
        public int CeilingPainting(double width, double length,
                                   double paintConsumption, double canVolume)
        {
            double ceilingArea = width * length;
            double paintNeeded = ceilingArea * paintConsumption;
            double cansCount = paintNeeded / canVolume;
            return (int)Math.Ceiling(cansCount);
        }
    }
}
