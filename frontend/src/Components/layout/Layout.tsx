import Navbar from '../Layout/Navbar';
import Footer from '../Layout/Footer';
import Sidebar from '../Layout/Sidebar';
import { Outlet } from 'react-router-dom';
const Layout = () => 
{
    return (
        <>
            <Navbar/>
            <Sidebar/>
            <Outlet/>
            <Footer/>
        </>
    );
}
export default Layout;