export type PortfolioGet = {
    id: number;
    symbol: string;
    comanyName: string;
    purchace: number;
    lastDiv: number;
    industry: string;
    marketCap: number;
    comments: any
}

export type PortfolioPost = {
    symbol: string;
}

export type PortfolioDelete = {
    symbol: string;
}