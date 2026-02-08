import React from 'react'
import ReactDOM from 'react-dom/client'
import { createBrowserRouter, RouterProvider } from 'react-router-dom'
import PublicLayout from './Components/public/publicLayout/publicLayout';
import Layout from './Components/public/Layout/Layout';
import Home from './Components/public/Pages/Home';
import NotFound from './Components/public/Pages/NotFound';
import Login from './Components/public/Pages/Login';
import SignUp from './Components/public/Pages/SignUp';
import Product from './Components/public/Pages/Product';
import Features from './Components/public/Pages/Features';
import Pricing from './Components/public/Pages/Pricing'
import About from './Components/public/Pages/About';

const router = createBrowserRouter([
  {
    path: '/',
    element: <Layout />,          // GLOBAL layout
    children: [
      {
        element: <PublicLayout />, // PUBLIC layout
        children: [
          { index: true, element: <Home /> },
        ],
      },
    ],
  },
  {
    path: '/login',
    element: <Login/>
  },
  {
    path: '/signup',
    element: <SignUp/>
  },
  {
    path: '/product',
    element: <Product/>
  },
  {
    path: '/features',
    element: <Features/>
  },
  {
    path: '/pricing',
    element: <Pricing/>
  },
  {
    path: '/about',
    element: <About/>
  },
  // {
  //   path: '/userDashboard',
  //   element: <layoutUser/>,
  //   children: [
  //     {
  //       element: <userLayout/>
  //       children: [
  //         { index: true, element: <Dashboard/> }
  //       ],
  //     },
  //   ],
  // },
  {
    path: '*',
    element: <NotFound/>
  }
]);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
)
