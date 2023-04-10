// See https://aka.ms/new-console-template for more information

using modul8_1302213116;

BankTransferConfig config = new BankTransferConfig();

config.openingMessage(); int Nominal_transfer = Convert.ToInt32(Console.ReadLine());
config.Transaction(Nominal_transfer);
config.methodTransfer();
config.confirmation(); String conf = Console.ReadLine();
config.confirmationReact(conf); 