using TF.Constants;
using TF.Enums.Operation;

namespace TF.Model.Operation.OperationsByCursor
{
    public class OperationItem
    {
        /// <summary>
        /// Курсор.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Номер счета клиента.
        /// </summary>
        public string BrokerAccountId { get; set; }

        /// <summary>
        /// Идентификатор операции, может меняться с течением времени.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Идентификатор родительской операции, может измениться, если изменился id родительской операции.
        /// </summary>
        public string ParentOperationId { get; set; }

        /// <summary>
        /// Название операции.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата поручения.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Тип операции.
        /// </summary>
        public OperationType Type {  get; set; }

        /// <summary>
        /// Описание операции.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Статус поручения.
        /// </summary>
        public OperationState State { get; set; }

        /// <summary>
        /// Уникальный идентификатор инструмента.
        /// </summary>
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Figi.
        /// </summary>
        public string Figi { get; set; }

        /// <summary>
        /// Тип инструмента.
        /// </summary>
        public string InstrumentType { get; set; }

        /// <summary>
        /// position_uid-идентификатора инструмента.
        /// </summary>
        public string PositionUid { get; set; }

        /// <summary>
        /// Сумма операции.
        /// </summary>
        public MoneyValue Payment { get; set; }

        /// <summary>
        /// Цена операции за 1 инструмент.
        /// </summary>
        public MoneyValue Price { get; set; }

        /// <summary>
        /// Комиссия.
        /// </summary>
        public MoneyValue Commission { get; set; }

        /// <summary>
        /// Доходность.
        /// </summary>
        public MoneyValue Yield { get; set; }

        /// <summary>
        /// Относительная доходность.
        /// </summary>
        public Quotation YieldRelative { get; set; }

        /// <summary>
        /// Накопленный купонный доход.
        /// </summary>
        public MoneyValue AccruedInt { get; set; }

        /// <summary>
        /// Количество единиц инструмента.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Неисполненный остаток по сделке.
        /// </summary>
        public string QuantityRest { get; set; }

        /// <summary>
        /// Исполненный остаток.
        /// </summary>
        public string QuantityDone { get; set; }

        /// <summary>
        /// Дата и время снятия заявки.
        /// </summary>
        public DateTime CancelDateTime { get; set; }

        /// <summary>
        /// Причина отмены операции.
        /// </summary>
        public string CancelReason { get; set; }

        /// <summary>
        /// Массив сделок.
        /// </summary>
        public OperationItemTrades TradesInfo { get; set; }

        /// <summary>
        /// Идентификатор актива
        /// </summary>
        public string AssetUid { get; set; }
    }
}
