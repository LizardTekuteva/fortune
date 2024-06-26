### Прецедент: Сделать ставку
<img width="372" alt="Снимок экрана 2024-04-18 в 23 49 31" src="https://github.com/LizardTekuteva/fortune/assets/164531160/25d35ae2-6825-4be0-a837-6547b1468ab2">

**Основной сценарий**

| Операция    | Выбор символа и ввод суммы ставки |
|-------------|------------------------------------|
| Ссылки      | Прецедент "Сделать ставку"         |
| Предусловие | Игрок авторизован в системе казино и имеет достаточный баланс для совершения ставки |
| Постусловие | Ставка успешно зарегистрирована, и сумма ставки списана с баланса игрока |

**Альтернативный сценарий: Недостаточно средств для ставки**

| Операция    | Отображение сообщения об ошибке "Недостаточно средств для совершения ставки" |
|-------------|---------------------------------------------------------------------------|
| Ссылки      | Прецедент "Сделать ставку"                                                |
| Предусловие | Игрок авторизован в системе казино и пытается сделать ставку на сумму, превышающую его текущий баланс |
| Постусловие | Сообщение об ошибке отображено игроку |



### Прецедент: Просмотр правил игры
<img width="362" alt="Снимок экрана 2024-04-18 в 23 50 45" src="https://github.com/LizardTekuteva/fortune/assets/164531160/ebeb0798-bd3d-4985-bdea-afcc018e3acf">

**Основной сценарий**

| Операция    | Открытие раздела с правилами игры |
|-------------|-------------------------------------|
| Ссылки      | Прецедент "Просмотр правил игры"   |
| Предусловие | Игрок находится на экране, где предоставляется информация о правилах игры |
| Постусловие | Игрок ознакомлен с текстовым описанием правил игры |


### Прецедент: Пополнение баланса
<img width="355" alt="Снимок экрана 2024-04-18 в 23 51 06" src="https://github.com/LizardTekuteva/fortune/assets/164531160/d3a0c576-28b4-4c34-bd60-250a3f9fa909">

**Основной сценарий**

| Операция    | Переход в раздел управления счетом, выбор опции пополнения баланса, ввод суммы, подтверждение пополнения |
|-------------|--------------------------------------------------------------------------------------------------------------|
| Ссылки      | Прецедент "Пополнение баланса"                                                                              |
| Предусловие | Игрок авторизован в системе казино и находится в разделе управления счетом                                   |
| Постусловие | Баланс игрока успешно пополнен на указанную сумму и обновлен в системе                                        |


### Прецедент: Изменение размера ставки
<img width="412" alt="Снимок экрана 2024-04-18 в 23 51 25" src="https://github.com/LizardTekuteva/fortune/assets/164531160/a403ef90-5490-4fce-9785-c1b1f54e8aff">

**Основной сценарий**

| Операция    | Выбор опции изменения размера ставки, указание нового размера, подтверждение изменения |
|-------------|-----------------------------------------------------------------------------------------|
| Ссылки      | Прецедент "Изменение размера ставки"                                                     |
| Предусловие | Игрок авторизован в системе казино и находится на экране, где предоставляется возможность сделать ставку |
| Постусловие | Размер ставки игрока успешно изменен и подтвержден                                      |

**Альтернативный сценарий: Отмена изменения размера ставки**

| Операция    | Отмена изменения размера ставки |
|-------------|----------------------------------|
| Ссылки      | Прецедент "Изменение размера ставки" |
| Предусловие | Игрок начал процесс изменения размера ставки |
| Постусловие | Изменение размера ставки отменено |
