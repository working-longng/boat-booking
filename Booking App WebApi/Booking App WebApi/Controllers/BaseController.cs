using Booking_App_WebApi.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Booking_App_WebApi.Controllers
{
    public class BaseController : Controller
    {
        public IConfiguration _config;
        public readonly IMongoCollection<User> _usersCollection;
        //public readonly IMongoCollection<OrderModel> _ordersCollection;
        //public readonly IMongoCollection<HistoryModel> _historysCollection;
        //public readonly IRabitMQProducer _rabitMQProducer;
        public BaseController(IConfiguration config)
        {
            _config = config;
            var client = new MongoClient(_config["ImageMgDatabase:ConnectionString"]);
            var database = client.GetDatabase(_config["ImageMgDatabase:DatabaseName"]);
            _usersCollection = database.GetCollection<User>(_config["ImageMgDatabase:UserCollectionName"]);
            //_ordersCollection = database.GetCollection<OrderModel>(_config["ImageMgDatabase:OrderCollectionName"]);
            //_historysCollection = database.GetCollection<HistoryModel>(_config["ImageMgDatabase:HistoryCollectionName"]);
            //_rabitMQProducer = rabitMQProducer;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
