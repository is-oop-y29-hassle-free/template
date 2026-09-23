using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

// Тестовые сценарии из задания (раздел «Тестовые сценарии»).
// Значения по умолчанию: флот – один Venture, стратегия «Общий трюм»;
// пояс «Пояс A» – 4 а.е., Veldspar; налог 0;
// прайс-лист – Tritanium 4, Pyerite 10, Mexallon 70, Isogen 150.
public class ContractScenarioTests
{
    /*
    private readonly PriceList _defaultPriceList;

    public ContractScenarioTests()
    {
        // например:
        _priceList = new PriceList()
            .AddMineral(new Tritanium(), 4.0m)
            .AddMineral(new Pyerite(),  10.0m)
            .AddMineral(new Mexallon(), 70.0m)
            .AddMineral(new Isogen(),  150.0m);
    }
    */

    [Fact(DisplayName = "Сценарий 1. Контракт на срок")]
    public void TimeContract_WithSingleVenture_IsCompleted()
    {
        // Arrange: контракт на 6 ч
        // var contract = new Contract(...);

        // Act
        // var result = calculator.Calculate(contract, ...);

        // Assert: выполнен; 1 рейс, время работы 6 ч, добыто 400 м³;
        // Tritanium – 8000; выручка 32 000, аренда 6000, прибыль 26 000
        // Assert.Equal(result.Status, ContractStatusEnum.Completed);
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 2. Пустой флот")]
    public void Fleet_WithoutShips_CannotBeCreated()
    {
        // Arrange + Act: создание флота без кораблей

        // Assert: исключение
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 3. Контракт на объём")]
    public void VolumeContract_WithSingleVenture_IsCompleted()
    {
        // Arrange: контракт на 1000 м³

        // Act

        // Assert: выполнен; 3 рейса (400, 400, 200 м³), время работы 16 ч;
        // Tritanium – 20 000; выручка 80 000, аренда 16 000, прибыль 64 000
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 4. Отклонение по сроку")]
    public void TimeContract_TooShort_IsRejected()
    {
        // Arrange: контракт на 2 ч

        // Act

        // Assert: отклонён – срока не хватает на один рейс
        Assert.Fail("Сценарий не реализован");
    }

    [Fact(DisplayName = "Сценарий 5. Отклонение по прайс-листу")]
    public void Contract_WithIncompletePriceList_IsRejected()
    {
        // Arrange: пояс с Scordite, в прайс-листе нет цены Pyerite; контракт на 6 ч

        // Act

        // Assert: отклонён – в прайс-листе нет цены минерала из выхода руды
        Assert.Fail("Сценарий не реализован");
    }
}