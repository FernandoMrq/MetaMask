dotnet tool install --global dotnet-ef =====>>> Usado quando não está em projeto core e sim no Framework de desktop windows

1 Entity Design no startup

2 Entity Tools e Entity DabaseClient no Repository

Add-Migration inicial -StartupProject '0 - Client\MRQ.CryptoBot.Client' -Project '2 - Adapter\MRQ.CryptoBot.Repository'

Add-Migration dois -StartupProject '0 - Client\MRQ.CryptoBot.Client' -Project '2 - Adapter\MRQ.CryptoBot.Repository'

update-database -StartupProject '0 - Client\MRQ.CryptoBot.Client' -Project '2 - Adapter\MRQ.CryptoBot.Repository'

Algumas vezes o banco .db do sqlite não é movido para mesma pasta do projeto gerado no debug