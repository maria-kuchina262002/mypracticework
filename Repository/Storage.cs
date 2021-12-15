namespace mypracticework.Repository
{
    public static class Storage
    {
        public static readonly BillStorage BillStorage  = new BillStorage();
        public static readonly CashStorage CashStorage = new CashStorage();
        public static readonly ClientStorage ClientStorage = new ClientStorage();
        public static readonly DishStorage DishStorage  = new DishStorage();
        public static readonly StaffStorage StaffStorage  = new StaffStorage();
        public static readonly IngridientStorage IngridientStorage = new IngridientStorage();
        public static readonly MenuStorage MenuStorage  = new MenuStorage();
        public static readonly OrderStorage OrderStorage  = new OrderStorage();
        public static readonly PhotoStorage PhotoStorage = new PhotoStorage();
        public static readonly ReviewStorage ReviewStorage = new ReviewStorage();
        public static readonly ServiceStorage ServiceStorage = new ServiceStorage();
    }
}