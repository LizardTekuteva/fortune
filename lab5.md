
![Ef![SSnhNqd9eWw](https://github.com/LizardTekuteva/fortune/assets/164531160/12b16eba-ce39-499f-8610-7998ec98d8e5)


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
