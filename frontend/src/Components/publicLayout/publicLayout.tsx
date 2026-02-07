import { Outlet } from 'react-router-dom';
const publicLayout = () => 
{
    return(
        <>
            <Outlet/>
        </>
    );
}
export default publicLayout;