using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    /// <summary>
    /// ДОМАШНЯЯ РАБОТА: разработать методы тестирования контроллера PetController:
    /// Обновление данных UpdateTest
    /// Получение данных (по всем животным) GetAllTest
    /// Получение данных (по конкретному животному) GetByIdTest
    /// </summary>
    public class PetControllerTests
    {

        private PetController _petController;
        private Mock<IPetRepository> _mockPetRepository;

        public PetControllerTests() 
        {
            _mockPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mockPetRepository.Object);
        }

        [Fact]
        public void PetCreateBadRequestTest()
        {
            // НЕКОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [1] Подготовка данных для тестирования
            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.Name = "Бо";
            createPetRequest.Birthday = DateTime.Now.AddYears(-55);
            createPetRequest.ClientId = 1;

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Create(createPetRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void PetCreateTest()
        {
            // КОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [1] Подготовка данных для тестирования
            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.Name = "Барсук";
            createPetRequest.Birthday = DateTime.Now.AddYears(-15);
            createPetRequest.ClientId = 1;

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Create(createPetRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-50)]
        public void PetDeleteBadRequestTest(int petId)
        {
            // НЕКОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Delete(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(50)]
        [InlineData(100)]
        public void PetDeleteTest(int petId)
        {
            // КОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Delete(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void PetUpdateBadRequestTest()
        {
            // НЕКОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [1] Подготовка данных для тестирования
            UpdatePetRequest updatePetRequest = new UpdatePetRequest();
            updatePetRequest.PetId = 0;
            updatePetRequest.ClientId = -1;
            updatePetRequest.Name = "Мо";
            updatePetRequest.Birthday = DateTime.Now.AddYears(-35);

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Update(updatePetRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void PetUpdateTest()
        {
            // КОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [1] Подготовка данных для тестирования
            UpdatePetRequest updatePetRequest = new UpdatePetRequest();
            updatePetRequest.PetId = 1;
            updatePetRequest.ClientId = 1;
            updatePetRequest.Name = "Толстопуз";
            updatePetRequest.Birthday = DateTime.Now.AddYears(-10);

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Update(updatePetRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void PetGetAllTest()
        {
            // [1] Подготовка данных для тестирования
            _mockPetRepository.Setup(repository => repository.GetAll()).Returns(new List<Pet>()
            {
                new Pet(),
                new Pet(),
                new Pet()
            });

            // [2] Исполнение тестируемого метода
            ActionResult<List<Pet>> operationResult = _petController.GetAll();

            // [3] Подготовка эталонного результата (expected), проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository => repository.GetAll(), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-5)]
        public void PetGetByIdBadRequestTest(int petId)
        {
            // НЕКОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [2] Исполнение тестируемого метода
            ActionResult<Pet> operationResult = _petController.GetById(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(8)]
        public void PetGetByIdTest(int petId)
        {
            // КОРРЕКТНОЕ ПОВЕДЕНИЕ МЕТОДА
            // [2] Исполнение тестируемого метода
            ActionResult<Pet> operationResult = _petController.GetById(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;

            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);
        }
    }
}
