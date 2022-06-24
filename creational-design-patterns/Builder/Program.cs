using Builder.Creators;
using Builder.Interfaces;
using Builder.Models;

InstallmentDirector installmentDirector = new InstallmentDirector();
InstallmentBuilder installmentBuilder = new InstallmentBuilder();
installmentDirector.Builder = installmentBuilder;


Installment installment = installmentDirector.BuildInstallmentWithoutFeesAndTaxes();
Console.WriteLine(installment.ToString());

Installment installment2 = installmentDirector.BuildFullInstallment();
Console.WriteLine(installment2.ToString());



Console.ReadLine();