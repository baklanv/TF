using System.Xml.Linq;
using System;
using TF.Constants;
using TF.Enums.Operation;

namespace TF.Model.Operation.Operations
{
    public class Operation : IComparable
	{
        /// <summary>
        /// Идентификатор операции.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор родительской операции.
        /// </summary>
        public string ParentOperationId { get; set; }

        /// <summary>
        /// Валюта операции.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Сумма операции.
        /// </summary>
        public MoneyValue Payment { get; set; }

        /// <summary>
        /// Цена операции за 1 инструмент. Для получения стоимости лота требуется умножить на лотность инструмента.
        /// </summary>
        public MoneyValue Price { get; set; }

        /// <summary>
        /// Статус операции.
        /// </summary>
        public OperationState State { get; set; }

        /// <summary>
        /// Количество единиц инструмента.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Неисполненный остаток по сделке.
        /// </summary>
        public string QuantityRest { get; set; }

        /// <summary>
        /// Figi-идентификатор инструмента, связанного с операцией.
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Тип инструмента. Возможные значения:
        /// bond — облигация;
        /// share — акция;
        /// currency — валюта;
        /// etf — фонд;
        /// futures — фьючерс.
        /// </summary>
        public string InstrumentType { get; set; }

        /// <summary>
        /// Дата и время операции в формате часовом поясе UTC.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Текстовое описание типа операции.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Тип операции.
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Массив сделок.
        /// </summary>
        public List<OperationTrade> Trades { get; set; } //!!!!!!!!!!!!

        /// <summary>
        /// Идентификатор актива.
        /// </summary>
        public string AssetUid { get; set; }

        /// <summary>
        /// position_uid-идентификатора инструмента.
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public string InstrumentUid { get; set; }

		public int CompareTo(object? obj)
		{
			if ((obj == null) || (!(obj is Operation)))
				return 0;
			else
				return DateTime.Compare(Date, ((Operation)obj).Date);
		}
	}
}
