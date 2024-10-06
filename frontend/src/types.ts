export interface Payment {
    paymentId: number;
    userId: number;
    paymentStatus: string;
    paymentAmount: number;
    paymentDate: string; // You can adjust to Date if you handle parsing
  }
  export {};
