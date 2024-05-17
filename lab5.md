
<img width="645" alt="Снимок экрана 2024-05-17 в 19 29 09" src="https://github.com/LizardTekuteva/fortune/assets/164531160/d7416f6c-78f0-49ae-a702-96ca0ddc8393">

### Классы

**Player** — класс, представляющий игрока. Содержит основную информацию о игроке и методы для взаимодействия с игрой.

- **Атрибуты:**
  - name: String — имя игрока.
  - balance: float — баланс игрока.
- **Методы:**
  - placeBet(sector: Sector, amount: float)
  - topUpBalance(amount: float)
  - changeBetSize(newSize: float)

**Wheel** — класс, представляющий колесо игры. Управляет ставками и взаимодействием с секторами.

- **Атрибуты:**
  - sectors: List<Sector> — список секторов на колесе.
- **Методы:**
  - registerBet(sector: Sector, amount: float)
  - getRules(): String

**Sector** — класс, представляющий сектор на колесе. Содержит информацию о секторе.

- **Атрибуты:**
  - sectorId: int — уникальный идентификатор сектора.
  - name: String — имя сектора.
  - multiplier: float — множитель выигрыша для ставки на этот сектор.

**Bet** — класс, представляющий ставку игрока. Содержит информацию о ставке.

- **Атрибуты:**
  - sector: Sector — сектор, на который сделана ставка.
  - amount: float — сумма ставки.
- **Методы:**
  - getSectorInfo(sector: Sector): String
  - confirmBet(): boolean
