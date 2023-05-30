namespace IS201_N22_HTCL.Interface
{
    internal interface IUpComingDisc
    {
        void Attach(ICustomer observer);
        void Detach(ICustomer observer);
        void Notify();
    }
}
