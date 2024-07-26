import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import HomePage from "../Pages/HomePage/HomePage";
import SearchPage from "../Pages/SearchPage/SearchPage";
import ComapanyPage from "../Pages/CompanyPage/CompanyPage";
import CompanyProfile from "../Components/CompanyProfile/CompanyProfile";
import IncomeStatement from "../Components/IncomeStatement/IncomeStatement";
import DesignGuide from "../Pages/DesignGuide/DesignGuide";
import BalanceSheet from "../Components/BalanceSheets/BalanceSheet";
import CashflowStatement from "../Components/CashflowStatement/CashflowStatement";
import LoginPage from "../Pages/LoginPage/LoginPage";
import RegisterPage from "../Pages/RegisterPage/RegisterPage";
import ProtectedRoutes from "./ProtectedRoute";
import ProtectedRoute from "./ProtectedRoute";
import HistoricalDividend from "../Components/HistoricalDividend/HistoricalDividend";


export const router = createBrowserRouter([
    {
        path: '/',
        element: <App />,
        children: [
            { path: "", element: <HomePage /> },
            { path: "login", element: <LoginPage /> },
            { path: "register", element: <RegisterPage /> },
            { path: "search", element: <ProtectedRoute><SearchPage /></ProtectedRoute> },
            { path: 'design-guide', element: <DesignGuide /> },
            {
                path: "company/:ticker",
                element: (
                    <ProtectedRoute>
                        <ComapanyPage />
                    </ProtectedRoute>
                ),
                children: [
                    { path: "company-profile", element: <CompanyProfile /> },
                    { path: "income-statement", element: <IncomeStatement /> },
                    { path: "balance-sheet", element: <BalanceSheet /> },
                    { path: "cashflow-statement", element: <CashflowStatement /> },
                    { path: "historical-dividend", element: <HistoricalDividend /> },
                ]
            }
        ]
    }
])
