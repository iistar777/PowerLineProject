using CarApp.Enums;

namespace CarApp.Models
{
    public abstract class Car
    {
        /// <summary>
        /// Тип транспортного средства
        /// </summary>
        public readonly CarType CarType;

        /// <summary>
        /// Средний расход топлива
        /// </summary>
        public readonly decimal AverageFuel;

        /// <summary>
        /// Объем топливного бака
        /// </summary>
        public readonly decimal TankCapacity;

        /// <summary>
        /// Скорость
        /// </summary>
        public readonly decimal Speed;

        public Car(CarType carType, decimal averageFuel, decimal tankCapacity, decimal speed)
        {
            CarType = carType;
            AverageFuel = averageFuel;
            TankCapacity = tankCapacity;
            Speed = speed;
        }

        /// <summary>
        /// Вычисляет, сколько автомобиль может проехать на полном баке топлива и на остаточном количестве топлива в баке на данный момент
        /// </summary>
        /// <param name="fuel">Остаточное количество топлива в баке на данный момент</param>
        /// <param name="maxDistance">Расстояние, которое может проехать автомобиль на полном баке</param>
        /// <param name="remainingDistance">Расстояние, которое может проехать автомобиль на остаточном топливе</param>
        /// <returns></returns>
        public abstract void CalculateRemainingDistance(decimal fuel, out decimal maxDistance, out decimal remainingDistance);

        /// <summary>
        /// Отображает информацию о состоянии запаса хода в зависимости от пассажиров и груза
        /// </summary>
        /// <param name="passengers"></param>
        /// <param name="cargo"></param>
        public abstract void CalculatetRemainingDistanceWithWeight(int passengers = 0, decimal cargo = 0);

        /// <summary>
        /// Вычисляет время, за которое автомобиль преодолеет указанное расстояние при указанном количестве топлива
        /// </summary>
        /// <param name="fuel">Количество топлива</param>
        /// <param name="distance">Расстояние</param>
        public abstract void CalculateJourneyTime(decimal fuel, decimal distance);
    }
}
