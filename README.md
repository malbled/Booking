# Автоматизация бронирования номеров в гостинице
## Схема моделей

```mermaid
    classDiagram
    BookingRoom <.. Room
    BookingRoom <.. Guest
    Room <.. TypeRoom
    ServiceRendered <.. Service
    ServiceRendered <.. Guest
     
    class Service{
        +string Name
        +string Description
        +decimal Cost
    }
    class TypeRoom{
            +string Name
            +decimal Cost
        }
    class ServiceRendered{
        +Guid ServiceId
        +Guid GuestId
        +int Quantity
        +DateTimeOffset DateRend
    }
    class Room {
        +string Identifier
        +Guid TypeRoomId
    }
    class Guest {
        +string FIO
        +string Passport
        +string Telephone
    }

    class BookingRoom {
        +Guid RoomId
        +Guid GuestId
        +DateTimeOffset DateCheckIn
        +DateTimeOffset DateCheckOut
    }
