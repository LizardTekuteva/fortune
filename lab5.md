
<img width="670" alt="Снимок экрана 2024-05-20 в 22 52 41" src="">

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
