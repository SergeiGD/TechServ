namespace Forms_TechServ.classes.orders
{
    public enum OrderStatus
    {
        Canceled,
        Finished,
        WaitingForAnswer,
        WaitingForDiagnostic,
        WaitingForPrepayment,
        WaitingForRefund,
        WaitingForRepairing,
        WaitingForSpareParts,
        WaitingForPayment,
        Unknown
    }
}