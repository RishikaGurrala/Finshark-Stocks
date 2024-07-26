import React, { useEffect, useState } from 'react'
import { CompanyTenK } from '../../company';
import { getTenk } from '../../api';
import TenKItemFinder from './TenKItemFinder/TenKItemFinder';
import Spinner from '../Spinner/Spinner';

interface Props  {
    ticker: string;
}

const TenKFinder = ({ticker}: Props) => {
    const [companyData, setCompanyData] = useState<CompanyTenK[]>();
    useEffect(()=> {
        const getTenKData = async () => {
            const value = await getTenk(ticker);
            setCompanyData(value?.data)
        }
        getTenKData();
    }, [ticker])
  return (
    <div className='inline-flex rounded-md shadow-sm m-4' role="group">
        {companyData? (
            companyData?.slice(0,5).map((tenK)=> {
            return <TenKItemFinder tenK={tenK}  />
        }))
    : (
        <Spinner/>
    )}
    </div>
  )
}

export default TenKFinder