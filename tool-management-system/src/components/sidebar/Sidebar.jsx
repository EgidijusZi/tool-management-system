import { useState, useEffect, useContext, React } from 'react';
import { sidebarData } from './SidebarData';
import { Menu, MenuItem } from 'react-pro-sidebar';
import { Sidebar as SidebarMenu } from 'react-pro-sidebar';
import { useNavigate } from 'react-router-dom';
import { Box } from '@mui/material';
import { AuthContext } from '../../hooks/AuthContext';

const Sidebar = () => {
  const { user } = useContext(AuthContext);
  const navigate = useNavigate();
  const [selectedMenuItem, setSelectedMenuItem] = useState(
    localStorage.getItem('selectedMenuItem') || sidebarData[0].title
  );

  useEffect(() => {
    localStorage.setItem('selectedMenuItem', selectedMenuItem);
    localStorage.setItem('currentPath', window.location.pathname);
  }, [selectedMenuItem]);

  const handleClick = (menuRow) => {
    setSelectedMenuItem(menuRow.title);
    navigate(Object.values(menuRow.link).toString());
  };

  return (
    <Box sx={{ display: 'flex' }}>
      <SidebarMenu>
        <Menu>
          {sidebarData
            .filter(
              (menuRow) => !menuRow.role || menuRow.role.includes(user.role)
            )
            .map((menuRow) => {
              return (
                <MenuItem
                  key={menuRow.title}
                  onClick={() => {
                    handleClick(menuRow);
                  }}
                  active={selectedMenuItem === menuRow.title}
                  icon={menuRow.icon}
                >
                  {menuRow.title}
                </MenuItem>
              );
            })}
        </Menu>
      </SidebarMenu>
    </Box>
  );
};

export default Sidebar;
