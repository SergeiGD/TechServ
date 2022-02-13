namespace Forms_TechServ.classes.orders
{
    public static class StatusStringExtensions
    {
        public static string GetStatusString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.Canceled:
                    return "Отменен";
                case OrderStatus.Finished:
                    return "Завершен";
                case OrderStatus.WaitingForDiagnostic:
                    return "Ожидает диагностики";
                case OrderStatus.WaitingForAnswer:
                    return "Ожидает ответа клиента";
                case OrderStatus.WaitingForPrepayment:
                    return "Ожидает предоплаты";
                case OrderStatus.WaitingForRepairing:
                    return "Ожидает ремонта";
                case OrderStatus.WaitingForRefund:
                    return "Ожидает возврарата средств";
                case OrderStatus.WaitingForSpareParts:
                    return "Ожидает прибытия запчастей";
                case OrderStatus.WaitingForPayment:
                    return "Ожидает оплаты";

                default:
                    return "Неопределенный статус";
            }
        }

        public static OrderStatus GetStatusEnum(string status)
        {
            switch (status)
            {
                
                case "Отменен":
                    return OrderStatus.Canceled;
                case "Завершен":
                    return OrderStatus.Finished;
                case "Ожидает диагностики":
                    return OrderStatus.WaitingForDiagnostic;
                case "Ожидает ответа клиента":
                    return OrderStatus.WaitingForAnswer;
                case "Ожидает предоплаты":
                    return OrderStatus.WaitingForPrepayment;
                case "Ожидает ремонта":
                    return OrderStatus.WaitingForRepairing;
                case "Ожидает возврарата средств":
                    return OrderStatus.WaitingForRefund;
                case "Ожидает прибытия запчастей":
                    return OrderStatus.WaitingForSpareParts;
                case "Ожидает оплаты":
                    return OrderStatus.WaitingForPayment;

                default:
                    return OrderStatus.Unknown;
            }
        }
    }
}
