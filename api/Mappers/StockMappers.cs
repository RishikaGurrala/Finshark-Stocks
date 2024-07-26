using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Dtos.Stock;
using api.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
                Comments = stockModel.Comments.Select(c=> c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto StockDto)
        {
            return new Stock
            {
                Symbol = StockDto.Symbol,
                CompanyName = StockDto.CompanyName,
                Purchase = StockDto.Purchase,
                LastDiv = StockDto.LastDiv,
                Industry = StockDto.Industry,
                MarketCap = StockDto.MarketCap
            };
        }

        public static Stock ToStockFromFMP(this FMPStock fmpstock)
        {
            return new Stock
            {
                Symbol = fmpstock.symbol,
                CompanyName = fmpstock.companyName,
                Purchase = (decimal)fmpstock.price,
                LastDiv = (decimal)fmpstock.lastDiv,
                Industry = fmpstock.industry,
                MarketCap = fmpstock.mktCap
            };
        }
    }
}