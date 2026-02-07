import React from 'react'
import ReactDOM from 'react-dom/client'
import { createBrowserRouter, RouterProvider } from 'react-router-dom'
import PublicLayout from '../src/Components/publicLayout/publicLayout';
import Layout from '../src/Components/Layout/Layout';
import Home from '../src/Components/Pages/Home';
import './index.css'

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
]);

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
)
