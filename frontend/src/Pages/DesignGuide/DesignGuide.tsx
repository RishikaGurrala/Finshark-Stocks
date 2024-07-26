import React from 'react'
import Table from '../../Components/Table/Table'
import RatioList from '../../Components/RatioList/RatioList'
import { CompanyKeyMetrics } from '../../company'
import { TestDataCompany, testIncomeStatementData } from '../../Components/Table/testData'

type Props = {}

const data= TestDataCompany;

const tableConfig = [
    {
      label: "symbol",
      render: (company: any) => company.symbol,
    },
]

const DesignGuide = (props: Props) => {
  return (
   <>
   <h1>
    Design guide- This is the design guide for FIn Shark. 
    These are resuable components of the app with brief instructions on how to use them.
   </h1>
   <RatioList data={testIncomeStatementData} config={tableConfig}/>
   <Table data={testIncomeStatementData} config={tableConfig}/>
   <h3>
    Table - table takes in a configuration object and comapny data as params.
    Use the config to style your table
   </h3>
   </>
  )
}

export default DesignGuide