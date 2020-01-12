export class Order{
    Id: number;
    UserId: number;
    Items: string[];
    Adress: string;
    PaymentType: string;
    DeliveryType: string;
    OrderDate: Date;
    TotalPrice: number;
}