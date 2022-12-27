# dapper_unit_of_work

Unit of work + dapper

1. Dodajemy serwis do tworzenia transakcji
   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Common/TransactionService.cs


2. Rejestrujemy serwis

   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Program.cs#L12


3. Konfigurujemy połączenie

   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Program.cs#L13


4. Konfigurujemy tworzenie nowej transakcji per request
   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Program.cs#L20


5. Tworzymy Unit of work

   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Common/UnitOfWork.cs


6. Tworzymy i rejestrujemy repozytoria
   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Common/UnitOfWork.cs


7. Tworzymy i rejestrujemy serwis korzystający z repozytoriów
   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Program.cs#L26
   https://github.com/PiotrFerenc/dapper_unit_of_work/blob/main/Payment/Services/PaymentService.cs
