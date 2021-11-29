namespace mypracticework.Repository
{
    public static class Storage
    {
        public static BillStorage BillStorage { get; } = new BillStorage();
        public static CashStorage CashStorage { get; } = new CashStorage();
        public static DishStorage DishStorage { get; } = new DishStorage();
        public static EmployeeStorage EmployeeStorage { get; } = new EmployeeStorage();
        public static IngridientStorage IngridientStorage { get; } = new IngridientStorage();
        public static MenuStorage MenuStorage { get; } = new MenuStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();
        public static PhotoStorage PhotoStorage { get; } = new PhotoStorage();
        public static ReviewStorage ReviewStorage { get; } = new ReviewStorage();
        public static ServiceStorage ServiceStorage { get; } = new ServiceStorage();
    }
}