export interface Product {
  id: string; // Changed from number to string for GUID
  groupId?: string; // Optional, for product variants
  available: boolean;
  sellingType: string;
  categoryId: string;
  name: string;
  price?: number; // Optional, as some items might not have a price
  currencyId: string;
  description: string;
  barcode: string;
  stockQuantity: number;
  volumePrices?: VolumePrice[];
  parameters?: ProductParameter[];
}

export interface VolumePrice {
  quantity: number;
  currencyId: string;
  value: number;
}

export interface ProductParameter {
  name: string;
  value: string;
}