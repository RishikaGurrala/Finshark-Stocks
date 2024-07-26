import React, { useState, ChangeEvent, SyntheticEvent, useEffect } from 'react'
import Navbar from '../../Components/Navbar/Navbar'
import Search from '../../Components/Search/Search';
import ListPortfolio from '../../Components/Portfolio/ListPortfolio/ListPortfolio'
import CardList from '../../Components/CardList/CardList'
import { searchCompanies } from '../../api'
import { CompanySearch } from '../../company'
import { PortfolioGet } from '../../Models/Portfolio';
import { portfolioAddAPI, portfolioDeleteAPI, portfolioGetAPI } from '../../Services/PortfolioService';
import { handleError } from '../../Helpers/ErrorHandler';
import { error } from 'console';
import { toast } from 'react-toastify';

interface Props { }

const SearchPage = (props: Props) => {

    const [search, setSearch] = useState<string>("")
    const [portfolioValues, setPortfolioValues] = useState<PortfolioGet[] | null>([])
    const [searchResults, setSearchResults] = useState<CompanySearch[]>([])
    const [serverError, setServerError] = useState<string>("")

    useEffect(() => {
        getPortfolio();
    }, [])

    const handleSearchChange = (e: ChangeEvent<HTMLInputElement>) => {
        setSearch(e.target.value)
        //console.log(e)
    }

    const getPortfolio = () => {
     portfolioGetAPI() 
     .then((res) => {
        if(res?.data) {
            setPortfolioValues(res?.data);
        }
     }).catch((error) => {
       setPortfolioValues(null);
     })
    }

    const onPortfolioCreate = (e: any) => {
        e.preventDefault();
        portfolioAddAPI(e.target[0].value)
        .then((res)=> {
            if(res?.status === 204){
                toast.success("Stock added to portfolio!");
                getPortfolio();
            }
        }).catch((e) => {
            toast.warning("Could not create portfolio item!");
        })
    }
    const onPortfolioDelete = (e: any) => {
        e.preventDefault();
        portfolioDeleteAPI(e.target[0].value)
        .then((res) => {
            if(res?.status == 200)
            {
                toast.success("Stock deleted from portfolio!");
                getPortfolio();
            }
        })
    }
    const onSearchSubmit = async (e: SyntheticEvent) => {
        e.preventDefault();
        const result = await searchCompanies(search);
        if (typeof result === "string") {
            setServerError(result)
        } else if (Array.isArray(result.data)) {
            setSearchResults(result.data)
        }
        //console.log(searchResults);
    }
    return (
        <div className="App">
            <Search 
            onSearchSubmit={onSearchSubmit} 
            search={search} 
            handleSearchChange={handleSearchChange} />
            <ListPortfolio 
            portfolioValues={portfolioValues!} 
            onPortfolioDelete={onPortfolioDelete} />
            <CardList 
            searchResults={searchResults} 
            onPortfolioCreate={onPortfolioCreate} />
            {serverError && <h1>serverError</h1>}
        </div>
    )
}

export default SearchPage