namespace Ex8_Facade
{
    public class RockerLaunher
    {
        private Rocket _rocket;

        public RockerLaunher(Rocket rocket)
        {
            _rocket = rocket;
        }

        public void Launch()
        {
            _rocket.FillFuel();
            _rocket.Fly();
            _rocket.RemoveStage1();
        }
    }
}