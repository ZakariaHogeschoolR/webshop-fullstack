import Navbar from './Navbar';
import Footer from './Footer';
import Sidebar from './Sidebar';
import { Outlet } from 'react-router-dom';
const Layout = () => 
{
    return (
        <div>
            <Navbar scrl={false} />
            <Sidebar/>
            <Outlet/>
            <Footer/>
        </div>
    );
}
export default Layout;