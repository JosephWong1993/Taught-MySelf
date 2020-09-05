Imports CarLibrary

Module Module1

    Sub Main()
        Console.WriteLine("***** VB Library Client App *****")

        '通过Dim关键字声明本地变量
        Dim myMiniVan As New MiniVan()
        myMiniVan.TurboBoost()

        Dim mySportsCar As New SportsCar()
        mySportsCar.TurboBoost()

        Dim dreamCar As New PerformanceCar()
        '使用继承的属性
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()

        Console.ReadLine()
    End Sub

End Module
